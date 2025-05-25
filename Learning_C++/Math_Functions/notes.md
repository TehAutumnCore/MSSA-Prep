# Math Functions


std::floor()
std::ceil()
std::abs()
std::cos() -> Calculates the Cosine of an angle (in radians)
std::exp()
std::log() -> Returns the natural logarithm of a number(base e, where e ~ 2.71828). -> std::log(e) returns 1
std::pow()
std::sin() -> Calculates the Sine of an angle (in radians) -> std::sin(pi/2) returns 1
std::sqrt()
std::round
std::tan()


```cpp
#include <cmath>

double weight {7.7};
//Floor - Round down
std::cout << "Weight rounded to floor is : " << std::floor(weight) << std::endl;

//ceil - Round up
std::cout << "Weight rounded to ceil is : " << std::ceil(weight) << std::endl;


//abs
double savings{-5000};
weight {7.7};
std::cout << "Abs of weight is : " << std::abs(weight) << std::endl;
std::cout << "Abs of savings is : " << std::abs(savings) << std::endl;

// exo(x) = e^x
//exp: f(x) = e ^ x, where e = 2.71828
double exponential = std::exp(10);
std::cout << "The exponential of 10 is : " << exponential << std::endl;

//pow
std::cout << "3 ^ 4 is : "<< std::power(3,4) << std::endl;
std::cout << "9 ^ 3 is : "<< std::power(9,3) << std::endl;

//log : reverse function of pow. if 2^3 = 8, log 8 in base 2 = 3. Log is like asking
//to which exponent should we elevate 2 to get eight ? Log, by default computes the log
//in base e. There also is another function which uses base 10 called log10.

//Try the reverse operation of e^4 = 54.59, it will be log 54.59 in base e = ?
std::cout << "Log ; to get 54.59, you would elevate e to the power of : " << std::log(54.59) << std::endl;

//log10, 10^4 = 10000, to get 10k, you'd need to elevate 10 to the power of ?, this is log in base 10.
std::cout << "To get 1000, you'd need to elevate 10 to the power of : " << std::log10(10000) << std::endl;

//sqrt
std::cout << "the square root of 81 is : " << std::sqrt(81) << std::endl;

//round. Halfway points are rounded away from 0. 2,5 is rounded to 5 for example
std::cout << "3.654 rounded to : " << std::round(3.654) << std::endl;
std::cout << "2.5 is rounded to : " << std::round(2.5) << std::endl;
std::cout << "2.4 is rounded to : " << std::round(2.4) << std::endl;

const double pi = 3.141592653589793;

// sin(x) : sine of angle in radians
std::cout << "sin(pi/2) = " << std::sin(pi / 2) << std::endl; // Should be close to 1
std::cout << "sin(0) = " << std::sin(0) << std::endl;         // 0

// cos(x) : cosine of angle in radians
std::cout << "cos(0) = " << std::cos(0) << std::endl;         // 1
std::cout << "cos(pi) = " << std::cos(pi) << std::endl;       // -1

// log(x) : natural logarithm (base e)
double e = std::exp(1); // e ≈ 2.71828
std::cout << "log(e) = " << std::log(e) << std::endl;         // Should be 1
std::cout << "log(54.59) = " << std::log(54.59) << std::endl; // Example from your note
```