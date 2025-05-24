# C++ Core Language VS Standard Library VS STL

## Core Features: Built-in language features, part of the C++ language itself, not libraries that include
    Data Types: int, char, float, bool
    Control Structures: if, switch, for, while
    Functions and function overloading: 
    Classes, Structs, inheritance, polymorphism:
    Templates:
    Exception Handling: try, catch, throw
    Pointers, References:
    Namespaces: enum, typedef, constexpr, inline

    These features are defined by the C++ standard and implementing by compilers(e.g., g++, clang)

## Standard Library: The C++ Standard library is a collection of pre-built, reusable components built on top of the core language. It includes the STL, but it's much broader.
    Input/output: std::cin, std::cout, <iostream>
    strings: std::string, <string>
    Time and date: <chrono>
    Math: <cmath>, <limit>
    Utilities: std::pair, std::tuple, std::optional,std::any
    Smart pointers: std::unique_ptr, std::future
    Concurrency: std::thread, std::mutex, std::future
    Algorithm and Containers: STL

    The standard library is standardized, portable, and always available with any compliant C++ compiler.

## STL: The STL is a subset of the Standard Library. It's mainly focused on data structures and algorithms, all built using templates.
    Containers:std::vector, std::list, std::deque,std::map,std::unordered_map,std::stack,std::queue
    Algorithms: std::sort,std::find,std::accumulate,std::for_each,std::copy
    Iterators: Allows you to traverse containers in a generic way

    STL is what makes C++ generic programming powerful and efficient.