# Number System
Binary: Base 2, uses digits 0 and 1. Prefix: 0b, or 0B(since C++14)
    int bin = 0b1010; //binary for decimal 10

    100101: 1*2^5+5+0*2^4+0*2^3+1*2^2+0*2^1+1*2^0

    10010: 1*2^4+0*2^3+0*2^2+1*2^1+0*2^0

    111: 1*2^2+1*2^1+1*2^0

Octal: Base 8: Uses digits 0 through 7, prefix 0(leading 0)
    int oct = 012; //Octal 12 is decimal 10

Hexadecimal: Based 16: uses digits 0-9 and letters A-F(or a-f). Prefix: 0x or 0X
    int hex = 0xA; // Hex A is decimal 10


Base 10
    2371 : (2*10^3)+(3*10^2)+(7*10^1)+(1*10^0)

    924 : (9*10^2)+(2*10^1)+(4*10^0)

    47 : (4*10^1)+(7*10^0)

3 Digits
Binary | Decimal
000         0
001         1
010         2
011         3
100         4
101         5
110         6
111         7

4 Digits
Binary | Decimal
0000        0
0001        1


5 Digits
Binary | Decimal
00000       0

Generalization
Digits |  Data Range
1           0~1
2           0~3
3           0~7
4           0~15
5           0~31
...         ...
n           0~2^n-1

In Practice:
Digits Bytes Data Range
8       1       0~255
16      1       0~65,535
32      1       0~34,359,738,367
64      1       0~18,466,744,073,709,551,615

Hexadecimal -> 6E30F13F -> 0 * 6E30F13F
Binary | Decimal | Hex
0000        0       0
...       ...     ...
1001       9        9
1010       10       A
...       ...     ... 
1111       15       F

Padding: Removing leading 0s to represent the same number shorter
1       0010    0100    1011    1010
0001    010     0100    1011    1010

```Cpp
int number1 = 15; //Decimal
int number2 = 17; //Octal
int number3 = 0x0f; //Hexadecimal
int number4 = 0b00001111; //Binary - C++14

std::cout << "Hello World !" << std::endl;

std::cout << "Number1 is : " << number1 << std::endl;
std::cout << "Number2 is : " << number2 << std::endl;
std::cout << "Number3 is : " << number3 << std::endl;
std::cout << "Number4 is : " << number4 << std::endl;
```

All data is represented by a bunch of grouped if 0's and 1's in memory
As the range of your data grows, so will the number of digits you need to represent the data in memory
Hexadecimal system makes it a little easier for humans to handle streams of data with 1's and 0's
Octal has the same goal as hexadecimal, but its almost no longer used in modern times. It's just mentioned here for your awareness.