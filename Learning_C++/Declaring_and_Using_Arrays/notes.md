# Declaring and Using Arrays

```cpp
//Declaring an array
int scores[10]; //An array storing 10 integers

//Reading values
std::cout << std::endl;
std::cout << "Reading out scores (manually) : " << std::endl;
std::cout << "scores[0] : " << scores[0] << std::endl;
std::cout << "scores[1] : " << scores[1] << std::endl;
//...
std::cout << "scores[9] : " << scores[9] << std::endl;

//Array Bounds
//Reading past bounds of your array : BAD!
//It's going to read out something you didn't put there.
// std::cout << "scores[10] : " << scores[10] << std::endl;


//Looping through an Array.
/*
    for (size_t i{0}; i < 10; ++i) {
        std::cout << "scores[" << i << "] : " << scores[i] << std::endl; //scores[i] : scores[i]
    }


    //Writing data into an array
    int scores[10]; // An array storing 10 integers

    //Writing data in an array
    scores[0] = 20;
    scores[1] = 21;
    scores[2] = 22;

    //Writing out of bounds. BAD!
    // scores[22] = 300;

    std::cout << std:endl;
    std::cout << "Manually writing data in array : " << std::endl;
    for(size_t i{0}; i < 10; ++i) {
        std::cout << "scores[" << i << "] : " << scores[i] << std::endl;
    }


    //Writing and reading out data with a loop
    int scores[10]; //An array storing 10 integers

    std::cout << std::endl;
    std::cout << "Writing data in array with loop : " << std::endl;

    //Write data
    for (size_t i{0}; i < 10; ++i) {
        scores[i] = i * 3;
    }

    //Read data out
    for (size_t i{0}; i < 10; ++i) {
        std::cout << "scores [" << i << "] : " << scores[i] << std::endl;
    }

    //Initialize the array at declaration

    std::cout << std::endl;
    std::cout << "Declare and initialize at the same time : " << std::endl;

    double salarys[5] {12.7,7.5,13.2,8.1,9.3};

    for(size_t i{0}; i < 5; ++i) {
        std::cout << "salary[" << i << "] : " << salaries[i] << std::endl; //salary[iteration]: element at i
    }


    // If you dont initialize all the elements, those you leave out are initialized to 0
    std::cout <<std::endl;
    std::cout << "Leaving out some elements un-initialized : " << std::endl;

    int families[5] {12,7,5};

    for(size_t i{0}; i < 5; ++i) {
        std::cout << "families[" << i << "] : " << families[i] << std::endl; 
    }
*/

    //Array Initization : Omitting elements
    //If you don't initialize all the elements, those you leave out
    //are initialized to 0

    std::cout << std::endl;
    std::cout << "Leaving out some elements un-initialized : " << std::endl;

    int families[5] {12,7,5};

    for(size_t i{0};i<5; ++i) {
        std::cout << "families [" << i << "] : " << families[i] << std::endl;
    }

    //Array Declaration : Omit size
    //Omit the size of the array at declaration
    int class_sizes[] {10,12,15,11,18,17};

    for(auto value : class_sizes) {
        std::cout << "value : " << value << std::endl;
    }

    // Constant Arrays
    //Constant Arrays, can't be modified
    const int multipliers[] {22,30,15};
    multipliers[1] = 20; // Can't change elements of a const array: ERROR

    //Operations on data stored in arrays
    //sum up scores array, store result in sum

    int sum{0};
    for(int element : scores) {
        sum += element;
    }
    std::cout <<"score sum : " << sum << std::endl;
```