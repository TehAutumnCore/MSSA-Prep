# Flow Control : Conditional Programming
```cpp
#include <iostream>

int main() {
    bool red = {false};
    bool green {true};
    bool yellow {false};
    bool police_stop{true};
    /*
    If green : go
    If red, yellow : stop
    If green and police_stop : stop
    */

    if (red) {
        std::cout << "Stop" << std::endl;
    }
    if (yelow) {
        std::cout << "Slow down" << std::endl;
    }
    if (green) {
        std::cout << "Go" << std::endl;
    }
    return 0;
}
```