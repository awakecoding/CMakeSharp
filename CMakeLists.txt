cmake_minimum_required(VERSION 2.8)

project(HelloWorld)

set(CMAKE_LOCAL_ROOT ${CMAKE_SOURCE_DIR}/cmake)
set(CMAKE_MODULE_PATH ${CMAKE_MODULE_PATH} "${CMAKE_LOCAL_ROOT}/Modules")

enable_language(CSharp)

add_subdirectory(Hello)

