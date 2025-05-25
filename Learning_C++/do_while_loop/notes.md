# Do while loops
While loop : Checks the condition first, but might never run if the condition is false from the start

do...while loop: Runs the loop body first, then checks the condition, and always runs atleast once, even if the condition is false.
```cpp
const unsigned int COUNT {10};
unsigned int i {11};//initialization

do{
    std::cout << "[" << i << "] : I love C++" << std::endl;
    ++i;//increment
} while (i < COUNT); // Test


```