
set(MODULE_NAME "hello-executable")
set(MODULE_PREFIX "HELLO_EXECUTABLE")

set(${MODULE_PREFIX}_SRCS
	HelloExecutable.cs)

add_executable(${MODULE_NAME} ${${MODULE_PREFIX}_SRCS})

set_target_properties(${MODULE_NAME} PROPERTIES LINKER_LANGUAGE CSharp)

