#include <iostream>
#include <string>
#include <format>

int main() {
    /*
    //Printing data
    std::cout << "Hello C++ 20 " << std::endl;
    
    int age{21};
    std::cout << "Age : " << age << std::endl;
    
    std::cerr << "Error message : Something is wrong" << std::endl;
    std::clog << "Log message : Something happened "<< std::endl;
    */

    /* 
    int age1;
    std::string name;
    
    std::cout << "Please type your name and age : " << std::endl;
    // std::cin >> name;
    // std::cin >> age1;
    std::cin >> name >> age1;
    
    std::cout << "Hello " << name << ", You are " << age1 << " years old!" << std::endl;
    // std::cout << std::format("Hello {}, you are {} years old!\n",name,age1); //dont forget to #include <format>
    */


    //Data with spaces
    std::string full_name;
    int age3;

    std::cout << "Please type in your full name and age" << std::endl;

    std::getline(std::cin, full_name); //getline is for inputs with spaces such as firstname (space) lastname 
    std::cin >> age3;

    std::cout << "Hello " << full_name << ", You are " << age3 << " years old!" << std::endl;
    // std::cout << std::format("Your full_name is: {}\n", full_name,age3);

    return 0;
}