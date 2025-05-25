#include <iostream>

int main() {
    // std::cout << "I love C++" << std::endl;
    // std::cout << "I love C++" << std::endl;
    // std::cout << "I love C++" << std::endl;
    // std::cout << "I love C++" << std::endl;
    // std::cout << "I love C++" << std::endl;
    // std::cout << "I love C++" << std::endl;
    // std::cout << "I love C++" << std::endl;
    // std::cout << "I love C++" << std::endl;
    // std::cout << "I love C++" << std::endl;
    // std::cout << "I love C++" << std::endl;
    
    for (int i = 1; i <= 10; i++) { // i = 0; i < 10
        std::cout << "I love C++    i: "<< i << std::endl;
        }
        
/*
    //unsigned says we're using i for non-negative counting
    for(unsigned int i{}; i < 10; ++i) { // {} avoids narrowing conversions(double to int) //
        std::cout << "I love C++" << std::endl;
    }


    //Pre-Increment
    // Increments the variable before its used in the expression
    int i = 5;
    int a = ++i;

    //Post-Increment
    // Uses the current value first, then increments
    int i = 5;
    int a = i++;
    for(size_t i{}; i<10; ++i) k
        std::cout << "I love C++" << std::endl;
    }

    //Other operations in the loop body
    for( size_t j{0}; j < 10; ++j) {
        std::cout << "j: " << j << ". Double that and you get " << 2 * j << std::endl;
    }

    //Can leave out the {}
    for(size_t k{};k<5;++k)
        std::cout << "Single statement in body. Can leave out {} on loop body" << std::endl;




    for(size_t l{0}; i < 10; ++l) {
            //i is valid to use within the boundaries of the {} here
            std::cout << "l is usable here, the value is : " << l << std::endl;
        }
        //If you try to access i here, youll get an error
        //i doesnt exist in the main functin local scope

        return 0;
    
        //iterator can live outside the loop scope to use within main function scope.
    size_t m{};
    for(m; m <10; ++m) {
        std::cout << "Using the m variable from main function local scope : " << m << std::endl;
    }
    std::cout << "Loop done, the value of j is : " << j << std::endl;
    
    //Can leave out the iterator declaration in the loop
    size_t n{};
    for( ; n < 10; ++n) {
        std::cout << "Using the n variable from main function local scope : " << n << std::endl;
    }
    std::cout << "Loop done, the value of n is : " << n << std::endl;
*/
    return 0;
}