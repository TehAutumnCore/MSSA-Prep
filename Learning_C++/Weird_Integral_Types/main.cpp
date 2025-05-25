#include <iostream>

int main() {
    
    short int var1 {10};
    short int var2 {20};
    char var3 {40};
    char var4 {50};

    std::cout << "\nshort int size\n";
    std::cout << "size of var1 : " << sizeof(var1) << std::endl;//2
    std::cout << "size of var2 : " << sizeof(var2) << std::endl;//2
    
    std::cout << "\nchar size\n";
    std::cout << "size of var3 : " << sizeof(var3) << std::endl;//1
    std::cout << "size of var4 : " << sizeof(var4) << std::endl;//1

    auto result1 = var1 + var2; //conversion to int(smallest type)
    auto result2 = var3 + var4; //conversion to int(smallest type)

    std::cout << "\nresult size\n";
    std::cout << "size of result1 : " << sizeof(result1) << std::endl;//4
    std::cout << "size of result2 : " << sizeof(result2) << std::endl;//4
    
    return 0;
}