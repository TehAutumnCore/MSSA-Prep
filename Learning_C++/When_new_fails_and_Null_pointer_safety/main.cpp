#include <iostream>

int main() {
    
/*
    // int * data = new int[10000000000000000000000]; //terminate called after throwing an instance of 'std::bad_alloc'
    for(size_t i{0}; i < 1000000; ++i){
        int * data = new int[1000000];
    }
*/
/*
    //exception - for code that will might fail
    //how to prevent program from crashing
    for(size_t i{0}; i < 100; ++i){

        try{
            int * data = new int[10000000000];
        }catch(std::exception& e) {
            std::cout << "Somethng went wrong : " << e.what() << std::endl;
        }
    }
*/
/*
    //std::nothrow
    for(size_t i{0}; i < 100; ++i){
        int * data = new(std::nothrow) int[10000000000];

        if(data!=nullptr){
            std::cout << "Data allocated" <<std::endl;
        }else {
            std::cout << "Data allocation failed" <<std::endl;
        }
    
    }
        std::cout << "Program ending well" << std::endl; //program didnt crash
*/

/*
    //null pointer safety
    int* ptr = nullptr; //preferred in modern c++
    int* ptr = 0; //works but not as clear
    int* ptr = NULL; //from <cstddef>, but avoid in modern c++

    //compact nullptr check
    if(p_number){
        std::cout << "p_number points to a valid address : " << p_number << std::endl;
    } else {
        std::cout << "p_number points to a INVALID address : " << std::endl;
    }



    //Calling delete on a pointer containing nullptr
    //Calling delete on a nullptr is OK
    int *p_number1 {};

    delete p_number1; //This wont cause any problem if p_number1 contains nullptr

    //So no need to overdo something like
    if (p_number1){
        delete p_number;
        p_number1 = nullptr;
    }

*/

    return 0;
}