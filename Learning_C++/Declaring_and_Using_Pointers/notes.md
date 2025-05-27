# Pointers
A Pointer is a variable that stores the memory address of another variable.
such as:
        int x = 42;
        int* ptr = &x;

         x is a regular integer
        &x gets the address of x
        ptr is a pointer to an int
*Direct memory access.* They're needed when you wan tto control exactly how memory is used or laid out and are especially important in embedded systems, games, operating systems, or anything real-time.
*Efficient parameter passing*Large objects or arrays are expensive to copy. Pass their address (via pointer) to avoid duplication
        ```cpp
        void modify(int* num) {
            *num = 100;
        }
        ```
*Dynamic Memory Allocation* Pointers can be used with new/delete to allocate memory at runtime. They're needed when you don't know in advance how much data you'll need.
```cpp 
int* arr = new int[10]; //array of 10 ints on heap 
```
*Data Structures* Used in Linked Lists, trees, graphs to connect nodes dynamically.
*Polymorphism/OOP* When using base and derived classes, pointers to base classes are needed to call virtual functions correctly. 


# Pointers - Using and Declaring
//Declaring Pointers

```cpp
//Declaring Pointers
int * p_number {}; //Can only store an address of
                    // a variable of type int
doubel * p_factional_number{}; //Can only store an address of a variable of type double

//Explicitely Initialize to nullptr
int * p_number1{nullptr};
int * p_fractional_numbers {nullptr}


//All pointer variables have the same size.

std::cout << "Size of number pointer : " << sizeof(number) << ", size of int : " << sizeof(p_number) << std::endl;
std::cout << "Size of fractional_number pointer : " << sizeof(fractional_number) << ", size of int : " << sizeof(p_fractional_number) << std::endl;
std::cout << "Size of number1 pointer : " << sizeof(number1) << ", size of int : " << sizeof(p_number1) << std::endl;
std::cout << "Size of fractional_number1 pointer : " << sizeof(fractional_number1) << ", size of int : " << sizeof(p_fractional_number1) << std::endl;


//Position of the * doesnt matter
//All work the same - int *p_number format is easier to understand when you have multiple variables declared on the same line
int*  p_number2{nullptr}
int * p_number3{nullptr} // <- this is just weird>
int  *p_number4{nullptr}

//Confusing as you wonder if other_int_var6 is also a pointer to int. It is not.
//The structure is exactly the same for the previous statement
int *p_number5{}, other_int_var{};
int* p_number6{}, other_int_var6{};

//It is better to sperate these declarations on different lines though.
int *p_number7{};
int other_int_var7{}; // No room for confusion this time.


//Initializing pointers and assigning them data.

//We know that pointers store addresses of variables
int int_var {43};
int *p_int{&int_var};//the address of operator(&)

std::cout << "Int var"<< int_var << std::endl;
std::cout << "p_int (Address in memory) : "<< p_int << std::endl;

//You can also change the address stored in a pointer any time.
int int_var1{65};

int_var1 = 126;

p_int = &int_var1; //Assign a different address to the pointer.
std::cout << "p_int (with different address) : " << p_int << std::endl;

//Pointers only store the type for which it was declared
int *p_int1{nullptr};
double double_var{33};

//p_int1 = &double_var; //Compile error

```