# Precedence and Associativity
C++ goes beyond PEMDAS by including:
    Comparison: ==, !=, <,> 
    Logic: && , ||, !
    Assignment: =, +=, -=
    Increment/Decrement: ++, --
    bitwise: &, |, ^, ~, <<, >>
*Good practice: Use Parentheses() to make your intent 100% clear.*

a + b * c - e/e - f + g
*Precedence: which operation to do first*
*Associativity: Which direction or which order*
Operator Precedence determines which operators are evaluated first when multiple appear in an expression
Higher precedence = evaluated earlier
* has higher precedence than +, so it happens first
int x = 2 + 3 * 4;  // x = 2 + (3 * 4) = 14;

Associativity determines what happens when two operators of the same precedence appear together. Most operators are left-to-right associative, but some (like assignments) are right-to-left.
int x = y = z =5;
// this works because = is right-associative
x = (y=(z=5));

It is better to make intent in your code as clear as possible by clearly using () to indicate which operations you want done first.