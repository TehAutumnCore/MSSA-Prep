# Ternary Operator
<!-- Ternary Expression -->
result = (condition) ? option1 : option 2;

<!-- if equivalent -->
if (condition) {
    result = option1;
} else {
    result = option2;
}


```cpp

int max{};

int a{35};
int b{20};

std::cout << std::endl;
std::cout << "Using regular if " << std::endl;

if (a > b) {
    max = a;
} else {
    max = b;
}
//types must much or be convertible
// max = (a > b) ? a : b;

std::cout << "max : " << max << std::endl;


//Ternary Initialization
std::cout << std::endl;
std::cout << "speed" << std::endl;
bool fast = false;

int speed { fast ? 300 : 150};

std::cout << "The speed is : " << speed << std::endl;

```

