# Input and output

Stream -> Purpose <!-- Character referrs to the textual I/O, but it can mean Character or Console -->
std::cout -> Printing data to the console(terminal) <!-- Character OUTput -->
std::cin -> Reading data from the terminal <!-- Character INput -->
std::cerr -> Printing errors to the console; unbuffered: output appears immediately <!-- character input, Character ERRor -->
std::clog -> Printing log messages to the console; buffered: it may delay output until the buffer flushes. Better for general logging or debugging info that isnt urgeant<!-- Character LOG -->



```cpp
int main(int argc, char **argv) {
    //Compiler syntax error : missing semicolon
    std::cout << "Hello World in C++20"<< std::endl;
    int a = {4};
    int b = {4};

    //Runtime Error
    int c = 10 / (a-b);
    std::cout << "The value of c is : " << c << std::endl;

    //Warnings
    20/0; //this throws a warning on gcc10.
    return 0;
}

//Printing Data

//std::cout Printing stuff to the console
std::cout << "Hello World!" << std::endl;

std::cout << "The number is : " << 12 << std::endl;

int age {21};
std::cout << "The age is : " << 12 << std::endl;

//Error
std::cerr << "std::cerr output : Something went wrong" << std:endl;

//Log message
std::clog << "std::clog output : This is a log message" << std::endl;



//Reading data in

int age;
std::string name;

std::cout << "Please type in your Last Name : " << std::endl;
std::cin >> name;


std::cout << "Please type in your age : " << std::endl;
std::cin >> age;

std::cout << "Hello " << name << "! You are " << age << " years old" << std::endl;


//Chaining std::cin

int age;
std::string name;

std::cout << "Please type in your Last name and age, separated by spaces : " << std::endl;

std::cin >> name >> age; //Input name and age

std::cout << "Hello " << name << "! You are " << age << "years old." << std::endl;

//getline when taking in input, best to use as it will include spaces
std::string full_name;
std::getline(std::cin, full_name);

```