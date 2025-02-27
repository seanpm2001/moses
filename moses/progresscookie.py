"""Progress "cookie" and related classes.

Those object are used to return progress information during long running operations.add()
Since we implement a REST API usually this is not possible (not using swagger/openapi or
other tools that are easy to integrate with many languages, at least).
Cookies can be created, passed to the operation and used to retrieve state while the main
call is still pending.add()

"""
import logging
import uuid
import threading
from typing import cast, Dict, Optional, List, Any
import singleton
from moses_exceptions import AbortError, MosesError


# pylint: disable = too-few-public-methods
# pylint: disable = too-many-instance-attributes
class ProgressCookieData:
    """Class used internally to store progress information about a pending operation."""

    def __init__(self) -> None:
        """Initialize the object."""
        # id is a valid name for an id
        # pylint: disable = invalid-name
        self.id = ""
        self.pending = True
        self.progress = -1
        self.messages: List[str] = []
        self.result = {"code": -1, "message": "", "description": ""}

    def to_json(self) -> Dict[str, Any]:
        """Convert object to an array of json-compatible key-value pairs.

        :return: properties as a dictionary
        :rtype: Dict[str, Any]

        """
        return self.__dict__


class ProgressCookie(ProgressCookieData):
    """Class used to store and return progress of a long running operation."""

    def __init__(self) -> None:
        """Initialize the object and generate a unique id for it."""
        super().__init__()
        self.id = str(uuid.uuid4())
        self.lock = threading.Lock()
        self.event = threading.Event()
        self.min = self.max = self.current = 0.0
        self.aborted = False

    def set_minmax(self, minv: float, maxv: float) -> None:
        """Configure range for progress reporting.

        :param minv: minimum
        :type minv: fload
        :param maxv: maximum
        :type maxv: float

        """
        self.min = min(minv, maxv)
        self.max = max(minv, maxv)

    def acquire(self) -> None:
        """Prevent other threads from changing object state."""
        self.lock.acquire()

    def release(self) -> None:
        """Allow other threads to take ownership of the object."""
        self.lock.release()

    def freeze(self, wait_for_update: bool) -> ProgressCookieData:
        """Return current object state to caller.

        :param wait_for_update: the call with return only when something
            has been changed in the object
        :type wait_for_update: bool

        :returns: Object with updated information
        :rtype: ProgressCookieData

        """
        if wait_for_update:
            self.event.wait(30)

        self.acquire()

        try:
            clone = ProgressCookieData()

            clone.id = self.id
            clone.pending = self.pending
            clone.progress = self.progress
            clone.messages = self.messages
            clone.result = self.result

            # we can clean messages (we do a new assign)
            self.messages = []
            self.event.clear()
        finally:
            self.release()

        return clone

    def append_message(self, message: str) -> None:
        """Append a new message to progress information.

        :param message: message
        :type message: str

        """
        self.check_for_abort()

        message = message.rstrip()

        if message is None or len(message) == 0:
            return

        self.acquire()
        try:
            self.messages.append(message)
            self.event.set()
        finally:
            self.release()

    def set_progress(self, value: int) -> None:
        """Update progress value.

        :param value: current value
        :type value: int

        """
        self.check_for_abort()

        self.acquire()
        try:
            val = min(value, 100)

            if val != self.progress:
                self.progress = val
                self.event.set()
        finally:
            self.release()

    def set_progress_minmax(self, value: float) -> None:
        """Update the value as float when min-max are configured.

        :param value: current value
        :type value: float

        """
        self.check_for_abort()

        self.acquire()

        try:
            self.current = value
            progress = min(
                100, int(((self.current - self.min) * 100.0) /
                         (self.max - self.min))
            )

            if progress != self.progress:
                self.progress = progress
                self.event.set()

        finally:
            self.release()

    def update_progress_minmax(self, increase: float) -> None:
        """Increase current progress value.

        :param increase: increase amount
        :type increase: float

        """
        self.check_for_abort()

        self.acquire()

        try:
            self.current += increase
            progress = min(
                100, int(((self.current - self.min) * 100.0) /
                         (self.max - self.min))
            )
            if progress != self.progress:
                self.progress = progress
                self.event.set()
        finally:
            self.release()

    def completed(self) -> None:
        """Set the operations as completed successfully."""
        self.check_for_abort()

        self.acquire()
        try:
            self.pending = False
            self.result["code"] = 200
            self.result["message"] = ""
            self.result["description"] = ""
            self.event.set()
        finally:
            self.release()

    def abort(self) -> None:
        """Ask to terminate current operation.

        Abort may not always be possible and may not be immediate

        """
        self.aborted = True

    def check_for_abort(self) -> None:
        """Check if an abort has been requestsed by the user.

        Abort is reported by generating an exception

        """
        self.acquire()
        aborted = self.aborted
        self.release()

        if aborted:
            raise AbortError()

    def report_error(self, exception: Exception) -> None:
        """Terminate the operation with an error.

        :param exception: exception that terminated the operation
        :type exception: Exception

        """
        self.acquire()
        try:
            self.pending = False

            if isinstance(exception, MosesError):
                moseserror = cast(MosesError, exception)
                self.result["code"] = moseserror.code
                self.result["message"] = moseserror.message
                self.result["description"] = moseserror.description
            else:
                self.result["code"] = 500
                self.result["message"] = str(exception)
                self.result["description"] = "Internal Error"

            self.event.set()
        finally:
            self.release()


class ProgressCookies(Dict[str, ProgressCookie],
                      metaclass=singleton.Singleton):
    """Static singleton with all existing cookies."""

    def create_cookie(self) -> ProgressCookie:
        """Allocate and returns a new progress cookie.

        :returns: new cookie
        :rtype: ProgressCookie

        """
        cookie = ProgressCookie()
        # pylint false positive
        # pylint: disable = unsupported-assignment-operation
        self[cookie.id] = cookie
        return cookie

    def delete_cookie(self, cookie_id: str) -> None:
        """Delete a cookie and abort the operation if it's still pending.

        :param cookie_id: id of the progress cookie
        :type cookie_id: str

        """
        # pylint false positives
        # pylint: disable = unsupported-membership-test
        # pylint: disable = unsupported-delete-operation
        if cookie_id in self:
            cookie = self[cookie_id]
            cookie.acquire()
            cookie.abort()
            del self[cookie_id]
            cookie.release()

    def get_update(
        self, cookie_id: str, wait_for_update: bool
    ) -> Optional[ProgressCookieData]:
        """Return up-to-date information about an operation.

        :param cookie_id: id of the progress cookie
        :type cookie_id: str
        :param wait_for_update: if true the call won't return until
            something changes in the progress information

        :return: update progress data
        :rtype: ProgressCookieData

        """
        # pylint false positive
        # pylint: disable = unsupported-membership-test
        if cookie_id in self:
            clone = self[cookie_id].freeze(wait_for_update)
            return clone
        return None


def progress_message(progress: Optional[ProgressCookie], message: str) -> None:
    """Output a message or ignore the call if progress is None.

    :param progress: progress object
    :type progress: ProgressCookie, optional
    :param message: message
    :type message: str
    """
    if progress is not None:
        progress.append_message(message)
    logging.info(message)


def progress_completed(progress: Optional[ProgressCookie]) -> None:
    """Output a message or ignore the call if progress is None.

    :param progress: progress object
    :type progress: ProgressCookie, optional
    """
    if progress is not None:
        progress.completed()


def progress_report_error(
    progress: Optional[ProgressCookie], exception: Exception
) -> None:
    """Output a message or ignore the call if progress is None.

    :param progress: progress object
    :type progress: ProgressCookie, optional
    :param exception: exception generated during operation
    :type message: exception
    """
    if progress is not None:
        progress.report_error(exception)
