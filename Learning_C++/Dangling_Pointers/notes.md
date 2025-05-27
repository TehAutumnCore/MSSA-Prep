# Dangling Pointers
A dangling pointer is a pointer that points to memory that has been freed or is no longer valid. This is dangerous because using it can lead to undefined behaviour such as crashes, data corruption, or security vulnerabilities.

3 kinds of dangling pointers
Uninitialized pointer
deleted pointer
multiple pointers pointing to the same memory.

How to avoid:
Initialize your pointers
Set pointer to nullptr after deleting.
Dont return addressed of local variables.
Use smart pointers like std::uniqueptr or std::shared_ptr(modern C++).
For multiple pointers to same address, make sure the owner pointer is very clear.

```cpp


```