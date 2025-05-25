# While loop
Repetitive tasks

//Pillars of any loop
- Iterator
- Starting point
- Test( Controls when the loop stops)
- Increment(Decrement)
- Loop body

```cpp
//Print I love C++ 10 times
unsigned int i{};
    while (i <= 10) {
        std::cout << "I love c++ i:" << i << std::endl;
        i++;
    }

const unsigned int COUNT{10};
unsigned int i {0};
while (i < COUNT) {
    std::cout <<" I love C++" << std::endl;
    ++i;
}
```