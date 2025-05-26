#include <iostream>

int main() {
    //Declaring an array of ints
    // int scores[10]; //specifies space for 10 integers; also provides junk data since array was not initialized

    //Read data
    // std::cout << "scores [0] : " << scores[0] <<std::endl;
    // std::cout << "scores [1] : " << scores[1] <<std::endl;
/*
    //Read with loop
    for(size_t i{0}; i < 10; ++i) {
        std::cout << "scores [" << i << "] : " << scores[i] << std::endl;
    }
*/

/*
    //Write data into an array
    scores[0] = 20;
    scores[1] = 21;
    scores[2] = 22;

    // Print data out
    for(size_t i{0}; i < 10; ++i) {
        std::cout << "scores [" << i << "] : " << scores[i] << std::endl;
    }
*/
/*
    //writing and reading data
    for(size_t i{0}; i < 10; ++i) {
        scores[i] = i * 10;
        std::cout << "scores [" << i << "] : " << scores[i] << std::endl;
    }
*/
/*
    //Initialize the array at declaration
    double salaries[5] {12.7,7.5,13.2,8.1,9.3};

    for(size_t i{0}; i < 5; ++i) {
        std::cout << "salary[" << i << "] : " << salaries[i] << std::endl; //salary[iteration]: element at i
    }
*/
/*
    // If you dont initialize all the elements, those you leave out are initialized to 0
    std::cout <<std::endl;
    std::cout << "Leaving out some elements un-initialized : " << std::endl;

    int families[5] {12,7,5};

    for(size_t i{0}; i < 5; ++i) {
        std::cout << "families[" << i << "] : " << families[i] << std::endl; 
    }
*/
/*
    //Array Declaration : Omit size
    //Omit the size of the array at declaration
    int class_sizes[] {10,12,15,11,18,17,23,56};

    //Will print with a range based for loop
    for(auto value : class_sizes) {
        std::cout << "value : "<< value << std::endl;
    }
*/

    // Constant Arrays
    //Constant Arrays, can't be modified
    const int multipliers[] {22,30,15};
    // multipliers[1] = 20; // Can't change elements of a const array: ERROR

    //Operations on data stored in arrays
    //sum up scores array, store result in sum
    int scores[]{2,5,8,2,5,6,9};
    int sum{0};
    for(int element : scores) {
        sum += element;
    }
    std::cout <<"score sum : " << sum << std::endl;

    return 0;
}