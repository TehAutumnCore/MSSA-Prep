#include <iostream>

int main() {
    bool red_light{false};
    bool green_light{true};

    if (red_light == true) {
        std::cout << "Stop!" << std::endl;
    } else {
        std::cout << "Go Through" << std::endl;
    }

    if (green_light) {
        std::cout << "The light is green!" << std::endl;
    } else {
        std::cout << "The light is NOT green!" << std::endl;
    }

    //sizeof()
    std::cout << "sizeof(bool) : " << sizeof(bool) << std::endl; // 1 byte

    //Printing out a bool
    //1 -->> true;
    //0 -->> false;

    std::cout<<std::endl;
    std::cout<<"red_light : " << red_light << std::endl; //0 ->  red_light isnt active
    std::cout<<"green_light : " << green_light << std::endl; //1 -> green_light is active
    
    std::cout << '\n';

    std::cout<<std::boolalpha;
    std::cout<<"red_light : " << red_light << std::endl; //0 ->  red_light isnt active
    std::cout<<"green_light : " << green_light << std::endl; //1 -> green_light is active

    return 0;
}