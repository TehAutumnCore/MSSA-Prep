#include <iostream>

int main() {
    int number1 = 15;//decimal
    int number2 = 017; //octal
    int number3 = 0x0F; //Hexadecimal
    int number4 = 0b00001111; //binary

    std::cout << "Number1 is : " << number1 << std::endl;
    std::cout << "Number2 is : " << number2 << std::endl;
    std::cout << "Number3 is : " << number3 << std::endl;
    std::cout << "Number4 is : " << number4 << std::endl;

    return 0;
}