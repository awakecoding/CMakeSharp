
set(MODULE_NAME "hello")
set(MODULE_PREFIX "HELLO")

set(${MODULE_PREFIX}_SRCS
	Hello.cs)

add_executable(${MODULE_NAME} ${${MODULE_PREFIX}_SRCS})

