//Virtual Memory
A trick that fools your program into thinking it is the only program running on your OS, and all memory resources belong to it.
-Each program is abstracted into a process, and each process has access to the memroy range of 0-~(2^n)-1, where N is 32 on 32 bit systems and 64 on 64 bit systems.

Real Memory (RAM) v Virtual Memory(2^n)-1

When the program is ran, it goes through a section of the CPU called the Memory Management Unit(MMU) which transforms the memory map and the real memory layout in the ram. 

The entire program is not loaded in real memory by the CPU and MMU. Only parts that are about to be executed are loaded. Making effective use of real memory, a valuable and lacking resource.

The Memory Management Unit(MMU) will assign programs their own sections on the real memory and the program will think it owns the all of the memory, and the MMU will transform the idea the program has into the real memory that we have on the computer.

# Program Memory Map
The memory map is a standard format defined by the OS. All programs written for that OS must conform to it. It is usually divided into some sections.
Program Memory Map is how your program's memory is structured.
*When a C++ program runs, its divided into sections in memory.*

Stack 
Automatically managed(grows/shrinks with function calls)
Fast, but limited in size
Variables are destroyed when the function returns

Heap
Used for dynamic memory
You control when memory is allocated and freed. 
More flexible, but must manually 'delete', what you 'new'.
```cpp
/*
High Address
+-------------------------+
|     System Memory       | ← Reserved for the OS / runtime system
+-------------------------+
|         Stack           | ← Local variables, function calls,... (grows down)
+-------------------------+
|         Heap            | ← Additional memory that can be queried for at run time; Dynamic memory (new/malloc) (grows up)
+-------------------------+
|         Data            | ← Global & static variables
+-------------------------+
|         Text            | ← Program instructions (your compiled code)
+-------------------------+
Low Address
*/

```

-----------------------------------------------------------------------


So far we've only been using memory allocated on the stack. We are going to see how one can allocate memory from the heap, and some of the difference between these mechanisms.

Stack:
Memory is finite
The developer isnt in full control of the memory lifetime
Lifetime is controlled by the scope mechanism

Heap
Memory is finite
The developer is in full control of when memory is allocated and when it's released.
Lifetime is controlled explicitly through new and delete operators.

#include <iostream>
int main(int argc, char **argv) {
    {
        int local_scope_var{33};
    }
    return 0;
}


# Dynamic Memory Allocation
Dynamic Memory Allocation is about managing memory manually at runtime.
*Used when you don't know how much memory you'll need until runtime.*

```cpp
//How we've used pointers so far
int number{22};

iint * p_number = &number;

std::cout << std::endl;
std::cout << "Declaring pointer and assigning address : " << std::endl;
std::cout << "number : " << number << std::endl;
std::cout << "p_number : " << p_number << std::endl;
std::cout << "&numbver : " << &number << std::endl;
std::cout <<"*p_number : " << std::endl;

int * p_number1; // Uninitialized pointer, contains junk address
int number1 {12};
p_number1 = &number1; //Make it point to a valid address
std::cout << std::endl;
std::cout << "Uninitialized pointer : " << std::endl;
std::cout << "*p_number1 : "<< *p_number1 << std::endl;
```

```cpp
//Allocate dynamic memory through 'new'
//Initialize the pointer with dynamic memory. Dynamically allocate.
//memory at run time and make a pointer point to it.

int *p_number4{nullptr};
p_number4 = new int; //Dynamically allocate space for a single int on the heap. This memory belongs to your program from now on. The System can't use it for anything else, until we return it. After this line executes, we will have a valid memory location allocated. The size of the allocated memory will be such that it can store th etype pointed to by the pointer.

*p_number4 = 77; //Writing into dynamically allocated memory.
std::cout << std::endl;
std::cout << "Dynamically allocating memory : " <<std::endl;
std::cout << "*p_number4"<< *p_number4 <<std::endl;


//Stack lifetime VS heap lifetime
#include <iostream>

int main(int argc, char **argv) {
    {
        int local_var{33};
        int *local_ptr_var = new int;
    }
    return 0;
}


//Releasing and Resetting
int *p_number4{nullptr};
p_number4 = new intl


delete p_number4;
p_number4 = nullptr;

```
```cpp

//It is also possible to initialize the pointer with a valid
//address up on declaration. Not with a nullptr
int *p_number5{ new int }; // Memory location contains junk value
int *p_number6{ new int(22) }; // use direct initialization
int *p_number7{ new int{23} }; // use uniform initialization

std::cout << std::endl;
std::cout << "Initialize with valid memory address at declaration : " << std::endl;
std::cout << "p_number5 : " << p_number5 << std::endl;
std::cout << "*p_number5 : " << *p_number5 << std::endl; // Junk value

std::cout << "p_number6 : " << p_number6 << std::endl;
std::cout << "*p_number6 : " << *p_number6 << std::endl;

std::cout << "p_number7 : " << p_number7 << std::endl;
std::cout << "*p_number7 : " << *p_number7 << std::endl;

//Remember to release the memory
delete p_number5;
p_number5 = nullptr;

delete p_number6;
p_number6 = nullptr;

delete p_number7;
p_number7 = nullptr;

```



```cpp
//heap
int* p = new int; //allocates 1 int on heap
*p = 42;

delete p; //free the memory amnually


//Arrays
int* arr = new int[5]; //array of 5 ints on heap

//use arr[0] to arr[4]
delete[] arr; //Important! Use delete[] for arrays.
```
