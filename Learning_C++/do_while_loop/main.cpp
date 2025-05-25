#include <iostream>

int main() {
    const unsigned int COUNT {10};
    unsigned int i {11};//initialization
    // unsigned int i {0};//initialization
    
    do{
        std::cout << "[" << i << "] : I love C++" << std::endl;
        ++i;//increment
    } while (i < COUNT); // Test    
return 0;
}