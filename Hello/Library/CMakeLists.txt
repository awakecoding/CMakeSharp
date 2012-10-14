
set(MODULE_NAME "hello-library")
set(MODULE_PREFIX "HELLO_LIBRARY")

set(${MODULE_PREFIX}_SRCS
	HelloLibrary.cs)

add_library(${MODULE_NAME} ${${MODULE_PREFIX}_SRCS})

set_target_properties(${MODULE_NAME} PROPERTIES LINKER_LANGUAGE CSharp)

