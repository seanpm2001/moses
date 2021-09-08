FROM #%platform.sdkbaseimage%#

RUN HOLD_PKGS='libdrm-common libdrm-amdgpu1:armhf libdrm2:armhf' \
    && apt-get -y update \
    && apt-get -y upgrade \
    && for P in $HOLD_PKGS ; do \
    echo ${P}=$(apt-cache show $P | sed -r -e '/^Version:/!d' -e 's/.* //' -e '/toradex/d' -e 'q') ; \
    done | xargs -r apt-get install -y --no-install-recommends \
    && apt-mark hold $HOLD_PKGS \
    && apt-get clean && apt-get autoremove && rm -rf /var/lib/apt/lists/*

# commands that should be run before installing packages (ex: to add a feed or keys)
#%application.sdkpreinstallcommands%#

# your regular RUN statements here
# Install required packages
RUN apt-get -q -y update \
    && apt-get -q -y install \
    python3-minimal \
    gdb-multiarch \
    procps \
    rsync \
    openssh-client \
    qt5-qmake:armhf \
    qtbase5-dev:armhf \
    && rm -rf /var/lib/apt/lists/*

RUN if [ ! -z "#%application.devpackages%#" ]; then \
    apt-get -q -y update \
    && apt-get -q -y install #%application.devpackages%# \
    && rm -rf /var/lib/apt/lists/* ; \
    fi

RUN if [ ! -z "#%application.sdkpackages%#" ]; then \
    apt-get -q -y update \
    && apt-get -q -y install #%application.sdkpackages%# \
    && rm -rf /var/lib/apt/lists/* ; \
    fi

# add qt pretty printer
RUN mkdir -p /home/torizon/.gdb/qt5printers/ && \
    cd /home/torizon/.gdb/qt5printers && \
echo 'python \n\
import sys, os.path \n\
sys.path.insert(0, os.path.expanduser("~/.gdb")) \n\
import qt5printers \n\
qt5printers.register_printers(gdb.current_objfile()) \n\
end' > /home/torizon/.gdbinit

ADD sdkfiles /home/torizon/.gdb/qt5printers/

#%application.sdkpostinstallcommands%#
