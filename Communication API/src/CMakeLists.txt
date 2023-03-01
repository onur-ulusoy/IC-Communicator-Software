include_directories(../inc)

set(src
    main.cpp
    libbluetooth.cpp
)

set(inc
    ../inc/libbluetooth.hpp
)

add_executable(comm-api ${src} ${inc})

set_target_properties(comm-api PROPERTIES OUTPUT_NAME "comm-api.out")