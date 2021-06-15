FROM --platform=#%platform.architecture%# #%platform.baseimage%#

# GDB-remote (we can use any port there)
EXPOSE 6502

#%application.expose%#

#%application.arg%#

# Make sure we don't get notifications we can't answer during building.
ENV DEBIAN_FRONTEND="noninteractive"

#%application.env%#

# commands that should be run before installing packages (ex: to add a feed or keys)
#%application.preinstallcommands%#

# your regular RUN statements here
# Install required packages
RUN apt-get -q -y update \
    && apt-get -q -y install \
    gdbserver \
    procps \
    && rm -rf /var/lib/apt/lists/*

RUN if [ ! -z "#%application.extrapackages%#" ]; then \
    apt-get -q -y update \
    && apt-get -q -y install #%application.extrapackages%# \
    && rm -rf /var/lib/apt/lists/* ; \
    fi

#%application.buildfiles%#
#%application.buildcommands%#

#%application.targetfiles%#

USER #%application.username%#

WORKDIR /#%application.appname%#

CMD stdbuf -oL -eL gdbserver 0.0.0.0:6502 /#%application.appname%#/#%application.exename%# #%application.appargs%#
