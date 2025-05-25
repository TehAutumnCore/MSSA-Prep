# for loops

```cpp
//Print I love C++ 10 times
std::cout << "I love C++" << std::endl;
std::cout << "I love C++" << std::endl;
std::cout << "I love C++" << std::endl;
std::cout << "I love C++" << std::endl;
std::cout << "I love C++" << std::endl;
std::cout << "I love C++" << std::endl;
std::cout << "I love C++" << std::endl;
std::cout << "I love C++" << std::endl;
std::cout << "I love C++" << std::endl;
std::cout << "I love C++" << std::endl;

for (int i = 1; i <= 10; i++) { // i = 0; i < 10
    std::cout << "I love C++"<< std::endl;
}

//unsigned says we're using i for non-negative counting
for(unsigned int i{}; i < 10; ++i) { // {} avoids narrowing conversions(double to int) //
    std::cout << "I love C++" << std::endl;
}


//Pre-Increment
Increments the variable before its used in the expression
int i = 5;
int a = ++i;

//Post-Increment
Uses the current value first, then increments
int i = 5;
int a = i++;

```
//Pillars of any loop
- Iterator
- Starting Point
- Test(controls when the loop stops)
- Increment(Decrement)
- Loop body

size_t: Not a type, just a type alias for some unsigned int representation.
Used to count things in memory such as the size of an array, number of bytes an object takes up, the number of elements in a container(like a vector or string)
It's a type that can never be negative and its guaranteed to be big enough to hold the size of any object on your system, even huge ones.
```cpp
for(size_t i{}; i<10; ++i) {
    std::cout << "I love C++" << std::endl;
}

//Other operations in the loop body
for( size_t i{0}; i < 10; ++i) {
    std::cout << "i: " << i << ". Double that and you get " << 2 * i << std::endl;
}

//Can leave out the {}
for(size_t i{};i<5;++i)
    std::cout << "Single statement in body. Can leave out {} on loop body" << std::endl;




int main (int argc, char **argv) {
    for(size_t i{0}; i < 10; ++i) {
        //i is valid to use within the boundaries of the {} here
        std::cout << "i is usable here, the value is : " << i << std::endl;
    }
    //If you try to access i here, youll get an error
    //i doesnt exist in the main functin local scope

    return 0;
}

//iterator can live outside the loop scope to use within main function scope.
size_t j{};
for(j; j <10; ++j) {
    std::cout << "Using the j variable from main function local scope : " << k << std::endl;
}
std::cout << "Loop done, the value of j is : " << j << std::endl;

//Can leave out the iterator declaration in the loop
size_t j{};
for( ; j < 10; ++j) {
    std::cout << "Using the j variable from main function local scope : " << j << std::endl;
}
std::cout << "Loop done, the value of j is : " << j << std::endl;






//Hard coded values are BAD
const size_t COUNT{10};
for(size_t j{}; j < COUNT; ++j) {
    std::cout << "The value of j is : " << j << std::endl;
}
```