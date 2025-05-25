#include <iostream>

int main() {
    int value{5};

    //increment by one
    value = value + 1;
    std::cout << "The value is : " << value << std::endl; //6

    value = 5; //Reset value to 5

    // Decrement by one
    value = value -1; //value-=1 or value-- // 4
    std::cout << "The value is : " << value << std::endl;

    std::cout << "-------------\n";

    //Postfix Increment/Decrement
    value = 5;

    std::cout << "The value is (incrementing) : " << value++ << std::endl;
    std::cout << "The value is : " << value++ << std::endl;

    //Decrement with postfix

    //Reset value to 5
    value = 5;

    std::cout << "The value is (decrementing) : " << value-- << std::endl;
    std::cout << "The value is : " << value << std::endl;

    std::cout << "-------------\n";

    value = 5;

    ++value;
    std::cout << "The value is (prefix++) : " << value << std::endl;

    //Reset value to 5
    value = 5;
    std::cout << "The value is (prefix++ in place) : " << ++value << std::endl;

    std::cout << std::endl;

    return 0;
}