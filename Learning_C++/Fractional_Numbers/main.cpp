#include <iostream>
#include <iomanip> //standard library header that provides input/output formatting.

int main() {
    float number1 {1.12345678901234567890f};// Precision:7
    double number2 {1.12345678901234567890};// Precision:15
    long double number3 {1.12345678901234567890L};// Precision 17

    //Print out the sizes
    std::cout << "sizeof float : " << sizeof(float) << std::endl;//4 
    std::cout << "sizeof double : " << sizeof(double) << std::endl;//8 
    std::cout << "sizeof long double : " << sizeof(long double) << std::endl;//16 

    std::cout << '\n';
    
    //Precision
    std::cout << std::setprecision(20); // Control the precision from std::cout.
    std::cout << "number1 is : " << number1 << std::endl; //7 digits
    std::cout << "number2 is : " << number2 << std::endl; // 15'ish digits
    std::cout << "number3 is : " << number3 << std::endl; // 15+ digits
    
    std::cout << '\n';
    //Float problem : the precision is usually too limited
    //for a lot of (float)(192400023)
    float number4 {192400023.0f};
    

    return 0;
}