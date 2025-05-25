# Assignments

```cpp
int var1{123}; //declare and initialize
std::cout << "var1 : "<< var1 << std::endl;

var1 = 55; //Assign
std::cout << "var1 : "<< var1 << std::endl;

bool state{false}; //Declare and initialize
std::cout <<std::boolalpha;
std::cout <<"state : " << state << std::endl;

state = true;

std::cout << "state : " << state << std::endl;

//Careful about auto assignments
auto var3{333u}; // Declare and initialize with type deduction
var3 = -22; //Assign negative number. DANGER!
std::cout << "var3 : " var3 << std::endl;

```