# Integers
3 ways to initialize
    Braced Initialization
    Functional Initialization
    Assignment Initialization

int:
    Stores whole numbers
    Typically occupies 4 bytes or more in memory

Variable
    A named piece of memory that you use to store specific types of data.

## Variable braced initialization
```cpp
//Variable may contain random garbage value. WARNING
int elephant_count;

int lion_count{}; //initializes to 0

int dog_count{10};//initializes to 10

int cat_count{15};//initializes to 15

//Can use expression as initializer
int domesticated_animals { dog_count + cat_count };

//Wont compile, the expression in the braces uses undeclared variables
int bad_initialization {doesnt_exist1 + doesnt_exist2 };

//2.9 is the type double, with a wider range than int. ERROR OR WARNING. -> fractional numbers are usually larger than integers in size and will cost a loss of data.
int narrowing_conversion {2.9}
```

## Functional variable initialization - not safe
```cpp
int apple_count(5);
int orange_count(10);
int fruit_count(apple_count + orange_count);
int bad_initialization(doesnt_exist3 + doesnt_exist4);

//information lost. less safe than braced initializers
int narrowing_conversion_functional(2.9);
```

## Assignment Initialization
```cpp
int bike_count = 2;
int truck_count = 7;
int vehicle_count = bike_count + truck_count;
int narrowing_conversion_assignment = 2.9;
```

# Size of a type in memory
sizeof will tell you how much memory an integer is taking in a program.
```cpp
std::cout << "sizeof int : "<< sizeof(int) <<std::endl;
std::cout << "sizeof truck_count : "<< sizeof(truck_count) <<std::endl;
```
# Variable Declaration Syntax
typename variable_name {initializer_value};