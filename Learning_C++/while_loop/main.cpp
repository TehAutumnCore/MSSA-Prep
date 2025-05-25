#include <iostream>

int main() {
    
    unsigned int i{};
    while (i <= 10) {
        std::cout << "I love c++ i:" << i << std::endl;
        i++;
    }

    const unsigned int COUNT{10};
    unsigned int j {0};
    while (j < COUNT) {
        std::cout <<" I love C++" << std::endl;
        ++j;
    }

    return 0;
}