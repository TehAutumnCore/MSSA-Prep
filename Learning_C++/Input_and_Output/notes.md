# Input and output

Stream -> Purpose
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


```