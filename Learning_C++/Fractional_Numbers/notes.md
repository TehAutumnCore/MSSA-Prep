# Fractional Numbers or Floating Point Types
Used to represent numbers with fractional parts in C++

Type        Size    Precision   Comment
float       4           7           -
double      8           15      recommended default
long double 12       >double    

Precision - The amount of numbers you can represent starting from the number in front of the decimal point
1.23456700001

```cpp

//Declare and initialize the variables
float number1 {1.12345678901234567890f};
double number2 {1.12345678901234567890};
long double number3 {1.12345678901234567890L};

//Print out the sizes
std::cout << "sizeof float : " << sizeof(float) << std::endl;
std::cout << "sizeof double : " << sizeof(double) << std::endl;
std::cout << "sizeof long double : " << sizeof(long double) << std::endl;


std::cout << std::setprecision(20); // Control the precision from std::cout.
std::cout << "number1 is : " << number1 << std::endl; //7 digits
std::cout << "number2 is : " << number2 << std::endl; // 15'ish digits
std::cout << "number3 is : " << number3 << std::endl; // 15+ digits

//Precision gone wrong
// float number4 {192400023}; //compile error

float number4 {192400023};
number4 = number4 + 1;
std::cout << "number4 is : << number 4 << std::endl;

double number5{192400023};
double number6{1.92400023e8};
double number7{1.924e8};
double number8{0.00000000003498};
double number9{3.498e-11};
```

IEEE_754 
Floating Point Numbers Memory Representation

n(floating point) /0 -> Infinity(+/-)
0.0/0.0 -> NaN (Not a Number)



```cpp
double number10{ 5.6};
double number11{};//Initialized to 0
double number12{}; //Initialized to 0

//Infinity
double result { number10 / number11 };

std::cout << number10 << "/" << number11 << " yields " << result << std::endl;
std::cout << result << " + " << number10 << " yields " << result + number10 << std::endl;

//NaN
result = number11 / number12;

std::cout << number11 << "/" << number12 << "=" << result << std::endl;
```
Remember the suffixes when initializing floating point variables otherwise the default will be a double
Double works well in many situations, so you will see it used a lot.