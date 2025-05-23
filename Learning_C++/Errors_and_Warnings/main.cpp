#include <iostream>

int main() {
    //Compile time error - no semi-colon, can check the problems tab
    std::cout << "Hello World!" << std::endl;
    
    //runtime error - Exception has occurred. Arithmetic exception
    int value = 7/0;
    std::cout << "value : "<< value << std::endl;
    return 0;

    //Also produces a warning, will highlight file yellow
}