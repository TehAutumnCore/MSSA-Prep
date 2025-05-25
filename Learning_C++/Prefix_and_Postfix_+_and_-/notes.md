# Prefix and Postfix + and -

```cpp
//Regular Increment / Decrement
int value{5};

//increment by one
value = value + 1;
std::cout << "The value is : " << value << std::endl;

value = 5; //Reset value to 5

// Decrement by one
value = value -1; //value-=1 or value--
std::cout << "The value is : " << value << std::endl;


//Postfix Increment/Decrement
value = 5;

std::cout << "The value is (incrementing) : " << value++ << std::endl;
std::cout << "The value is : " << value++ << std::endl;

//Decrement with postfix

//Reset value to 5
value = 5;

std::cout << "The value is (decrementing) : " << value-- << std::endl;
std::cout << "The value is : " << value << std::endl;
```
Prefix and postfix increment/decrement operators are cool.
But they only increment by one, what if we need to increment by a value other than 1, say 5 or 7. We'll see a way to do that in the next lecture.
There is no value** or **value, or //value or value//. They don't make sense, these prefix/postfix operators are only avaiilable for + and -, again because thats where they make sense.