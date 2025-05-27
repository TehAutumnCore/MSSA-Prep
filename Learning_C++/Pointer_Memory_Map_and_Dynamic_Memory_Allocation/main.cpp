#include <iostream>

int main() {
    int number{22};
/*
    int * p_number = &number;

    std::cout << std::endl;
    std::cout << "Declaring pointer and assigning address : " << std::endl;
    std::cout << "number : " << number << std::endl;
    std::cout << "p_number : " << p_number << std::endl;
    std::cout << "&numbver : " << &number << std::endl;
    std::cout <<"*p_number : " << *p_number << std::endl;

    int * p_number1; // Uninitialized pointer, contains junk address
    int number1 {12};
    p_number1 = &number1; //Make it point to a valid address
    std::cout << std::endl;
    std::cout << "Uninitialized pointer : " << std::endl;
    std::cout << "*p_number1 : "<< *p_number1 << std::endl;
*/
/*
    //Dynamic Heap memory
    int *p_number4{nullptr};
    p_number4 = new int; //Dynamically allocate space for a single int on the heap. This memory belongs to your program from now on. The System can't use it for anything else, until we return it. After this line executes, we will have a valid memory location allocated. The size of the allocated memory will be such that it can store th etype pointed to by the pointer.
    
    *p_number4 = 77; //Writing into dynamically allocated memory.
    std::cout << std::endl;
    std::cout << "Dynamically allocating memory : " <<std::endl;
    std::cout << "*p_number4 : "<< *p_number4 <<std::endl;

    //Return memory to the OS
    delete p_number4; //frees/release memory
    p_number4 = nullptr; //resets the memory
*/


    //It is also possible to initialize the pointer with a valid
    //address up on declaration. Not with a nullptr
    //short hand for int *p_number5 = &number5;
    int *p_number5{ new int }; // Memory location contains junk value
    int *p_number6{ new int(22) }; // use direct initialization
    int *p_number7{ new int{23} }; // use uniform initialization

    std::cout << std::endl;
    std::cout << "Initialize with valid memory address at declaration : " << std::endl;
    std::cout << "p_number5 : " << p_number5 << std::endl;
    std::cout << "*p_number5 : " << *p_number5 << std::endl; // Junk value

    std::cout << "p_number6 : " << p_number6 << std::endl;
    std::cout << "*p_number6 : " << *p_number6 << std::endl;

    std::cout << "p_number7 : " << p_number7 << std::endl;
    std::cout << "*p_number7 : " << *p_number7 << std::endl;

    //Remember to release the memory
    delete p_number5;
    p_number5 = nullptr;

    delete p_number6;
    p_number6 = nullptr;

    delete p_number7;
    p_number7 = nullptr;


    //Can reuse pointers
    p_number5 = new int(81); //allocating pointer space on the heap
    std::cout << "*p_number5 : " << *p_number5 << std::endl; 

    delete p_number5;
    p_number5 = nullptr;

    std::cout << "Program is ending well" <<std::endl;
    
    return 0;
}