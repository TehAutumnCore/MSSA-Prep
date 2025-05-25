# Booleans
Can store either True or False
```cpp
bool red_light{true};
bool green_light{false};

if (red_light == true) {
    std::cout << "Stop!" << std::endl;
} else {
    std::cout << "Go Through" << std::endl;
}

if (green_light) {
    std::cout << "The light is green!" << std::endl;
} else {
    std::cout << "The light is NOT green!" << std::endl;
}

//Printing out a bool
//1 -->> true;
//0 -->> false;

std::cout<<std::endl;
std::cout<<"red_light : " << red_light << std::endl;
std::cout<<"green_light : " << green_light << std::endl;

//Printing out true and false
std::cout << std::endl;
std::cout << std::boolalpha; //Force the output format to true/false
std::cout << std::noboolalpha; //Force the output format to 1/0
std::cout << "red_light" << red_light << std::endl;
std::cout << "green_light" << green_light << std::endl;
```

A byte can store 256 different values
Using it just to cover two states(true/false) is wasteful, especially for devices with hard memory constraints (think embedded devices)
There are techniques to pack even more data into a byte. We'll learn more abot these in a few upcoming chapters.