#include <iostream>
#include <iterator> //std::size() requires STL

int main() {
    //std::size() [C++17]
    std::cout << "\n-----Array size with std::size()------\n";
    int scores[] {10,12,15,11,18,17,22,23,24};

    //Modern - C++17 and newer
    //Can get the size with std::size()
    std::cout << "scores size : " << std::size(scores) << std::endl;

    //Print data out
    for(size_t i{0}; i < std::size(scores); ++i) {
        std::cout << "scores[" << i << "] : " << scores[i] << std::endl;
    }

    std::cout << "\n-----Array size with size of------\n";
    //Legacy Pre-C++17
    //Array size with sizeof

    std::cout << "Size of scores : " << sizeof(scores) << std::endl;
    std::cout << "Size of scores[0] : " << sizeof(scores[0]) << std::endl;
    //entire size of array / size of one element in array = how many elements are in the array 
    std::cout << "score item count : " << (sizeof(scores) / sizeof(scores[0])) << std::endl;

    size_t count {sizeof(scores)/sizeof(scores[0])};

    std::cout << "Printing out array items : " << std::endl;

    for(size_t j{0}; j < count; ++j) {
        std::cout << "scores[" << j << "] : " << scores[j] << std::endl;
    }

    std::cout << "\n-----Looping through an Array with for range------\n";
    //Looping through an Array
    int scoress[] {10,12,15,11,18,17,22,23,24};

    std::cout << "Using plain old range based for loop "<<std::endl;

    for(auto score : scoress) { //for range 
        std::cout << "score : " << score << std::endl;
    }
    std::cout << "\n";

    return 0;
}