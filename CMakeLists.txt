cmake_minimum_required(VERSION 2.8)

project(HelloWorld)

set(CMAKE_LOCAL_ROOT ${CMAKE_SOURCE_DIR}/cmake)
set(CMAKE_MODULE_PATH ${CMAKE_MODULE_PATH} "${CMAKE_LOCAL_ROOT}/Modules")

set(EXECUTABLE_OUTPUT_PATH ${CMAKE_CURRENT_BINARY_DIR}/bin)
set(LIBRARY_OUTPUT_PATH ${CMAKE_CURRENT_BINARY_DIR}/bin)

enable_language(CSharp)

add_subdirectory(Hello)

