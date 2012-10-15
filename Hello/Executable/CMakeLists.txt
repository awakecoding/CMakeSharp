
set(MODULE_NAME "HelloExecutable")
set(MODULE_PREFIX "HELLO_EXECUTABLE")

set(${MODULE_PREFIX}_SRCS
	HelloExecutable.cs)

add_executable(${MODULE_NAME} ${${MODULE_PREFIX}_SRCS})

set(${MODULE_PREFIX}_LIBS
	HelloLibrary)

target_link_libraries(${MODULE_NAME} ${${MODULE_PREFIX}_LIBS})

set_target_properties(${MODULE_NAME} PROPERTIES LINKER_LANGUAGE CSharp)

