# Characters and Text
```cpp
char character1 {'a'};
char character2 {'r'};
char character3 {'r'};
char character4 {'o'};
char character5 {'w'};

std::cout <<"character1 : " character1 << std::endl;
std::cout <<"character2 : " character2 << std::endl;
std::cout <<"character3 : " character3 << std::endl;
std::cout <<"character4 : " character4 << std::endl;
std::cout <<"character5 : " character5 << std::endl;
```

1 byte : 256 Possible values  -> Each matched to some character
*ASCII Table*
A = 65;
F = 70;
Z = 90;

a = 97;
f = 102;
z = 122; 

Is is possible to assign a valid ASCI code to a char variable and the corresponding character will be stored in. You can choose to iterpret that either as a character or a regular integral value.

```cpp
char value = 65; //ASCII character code for 'A'
std::cout << "value :" <<value << std::endl;
std::cout << "value(int) :" << static_cast<int>(value) << std::endl;
```