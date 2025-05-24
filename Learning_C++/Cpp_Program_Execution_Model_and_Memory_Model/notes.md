# C++ Program Execution Model & Memory Model

```cpp
#include <iostream>

int add_numbers(int a, int b) {
    return a + b;
}

int main(){
    int a = 10;
    int b = 10;
    int c;

    std::cout << "Statement1" << std::endl;
    std::cout << "Statement2" << std::endl;
    c = add_numbers(a,b)
    std::cout << "Statement3" << std::endl;
    std::cout << "Statement4" << std::endl;

    return 0;
}

```
Random Access Memory has the code you write stored into it, then the cpu will need to allocate space from top to bottom int a=10, int b=5, until the statement and store it on the cpu and will return to its address(where it came from on the ram) and continue to store everything that follows.