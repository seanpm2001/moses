tie_tests_prepare() {
    local WORKDIR=$1
    mkdir -p $WORKDIR
}

tie_tests_install_bats_clone() {
    local DIR=$1/$2
    local REPO=$2
    local VERSION=$3
    echo "Installing $REPO $VERSION..."
    if ! git clone --depth=1 https://github.com/bats-core/$REPO.git -b $VERSION $DIR >/dev/null 2>&-; then
        return 1
    fi
}

tie_tests_install_bats() {
    local DIR="$1/bats"
    local REPO=""
    local NAME=""
    local VERSION=""
    rm -Rf $DIR
    for REPO in bats-core:v1.3.0 bats-assert:v2.0.0 bats-file:v0.3.0 bats-support:v0.3.0; do
        NAME=$(echo $REPO | cut -d':' -f 1)
        VERSION=$(echo $REPO | cut -d':' -f 2)
        if ! tie_tests_install_bats_clone $DIR $NAME $VERSION; then
            echo "Error: could not clone $NAME repository!"
            return 1
        fi
    done
}

tie_tests_main() {
    local WORKDIR="workdir"
    tie_tests_prepare $WORKDIR && \
        tie_tests_install_bats $WORKDIR && \
        echo "Environment successfully configured to start integration tests."
}

tie_tests_main
export TIE_SETUP_LAUNCHED=1
