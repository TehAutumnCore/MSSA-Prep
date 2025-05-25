# Output Formatting

```cpp
#include <iostream>
#include <iomanip>

// std::endl -> Inserts a newline character (\n) and flushes the output buffer
std::cout << "\n---------------------------------------\n"
std::cout <<"Hello";
std::cout <<"World";
std::cout << std::endl;
std::cout <<"Hello\n";
std::cout <<"World\n";

// std::flush -> Flushes the output buffer without inserting a newline. Useful for immediate display of output(e/g/ progress bars)

std::cout << "\n---------setw------------------------------\n"
std::setw(10) -> Sets the field width to 10 characters for the next output only. (used with alignment and fill).

std::cout << "Unformatted table:" << std::endl;
std::cout << "Daniel"  << " " << "Gray"     << " " << "25" << std::endl;
std::cout << "Stanley" << " " << "Woods"    << " " << "33" << std::endl;
std::cout << "Jordan"  << " " << "Parker"   << " " << "45" << std::endl;
std::cout << "Joe"     << " " << "Ball"     << " " << "21" << std::endl;
std::cout << "Josh"    << " " << "Carr"     << " " << "27" << std::endl;
std::cout << "Izaiah"  << " " << "Robinson" << " " << "29" << std::endl;

std::cout << std::endl;
std::cout << "Formatted table : " << std::endl;

//std::format("{:[fill][align][width]}", value)
// : -> starts the format spec
// [fill] -> optional fill character, default is space
// [align] -> < for left, > for right, ^ for center
// [width] -> total field width (number of characters wide)
std::cout << std::format("{:>10}{:>10}{:>5}\n", Lastname, Firstname, Age);
std::cout << std::setw(10) << "Lastname" << std::setw(10) << "Firstname" << std::setw(5) << "Age" << std::endl;
std::cout << std::setw(10) << "Daniel"   << std::setw(10) << "Gray"     << std::setw(5) << "25" << std::endl;
std::cout << std::setw(10) << "Stanley"  << std::setw(10) << "Woods"    << std::setw(5) << "33" << std::endl;
std::cout << std::setw(10) << "Jordan"   << std::setw(10) << "Parker"   << std::setw(5) << "45" << std::endl;
std::cout << std::setw(10) << "Joe"      << std::setw(10) << "Ball"     << std::setw(5) << "21" << std::endl;
std::cout << std::setw(10) << "Josh"     << std::setw(10) << "Carr"     << std::setw(5) << "27" << std::endl;
std::cout << std::setw(10) << "Izaiah"   << std::setw(10) << "Robinson" << std::setw(5) << "29" << std::endl;



std::cout << "\n----------right-----------------------------\n"
// std::right -> Aligns output to the right within the set field width(std::setw).

std::cout << "\n---------left------------------------------\n"
// std::left -> Alights output to the left within the set field width(std::setw)

std::cout << "\n--------------boolalpha-------------------------\n"
// std::boolalpha -> Prints booleans as true or false instead of 1 or 0

//boolalpha and noboolapha : control bool output format : 1/0 or true/false

bool condition {true};
bool other_condition {false};

std::cout << "condition : " << condition << std::endl;
std::cout << "other_condition : " << other_condition << std::endl;

std::cout << std::endl;
std::cout << std::boolalpha;
std::cout << "condition : " << condition << std::endl;
std::cout << "other_condition : " << other_condition << std::endl;

std::cout << std::endl;
std::cout << std::noboolalpha;
std::cout << "condition : " << condition << std::endl;
std::cout << "other_condition : " << other_condition << std::endl;

std::cout << "\n------------showpos---------------------------\n"
// std::showpos -> Always shows a + sign for positive integers.

//showpos and noshowpos : show or hide the + sign for positive numbers

int pos_num {34};
int neg_num {-45};

std::cout << "pos_num : " << pos_num << std::endl;
std::cout << "neg_num : " << neg_num << std::endl;

std::cout << std::endl;
std::cout << std::showpos;
std::cout << "pos_num : " << pos_num << std::endl;
std::cout << "neg_num : " << neg_num << std::endl;

std::cout << std::endl;
std::cout << std::noshowpos;
std::cout << "pos_num :" << pos_num << std::endl;
std::cout << "neg_num :" << neg_num << std::endl;

std::cout << "\n--------dec-------hex----------oct--------\n"
// std::dec -> Switches output back to decimal format (default for integers).
// std::hex -> Outputs integers in hexadecimal format.
// std::oct -> Outputs integers in octal format.

//different number systems : std::dec, std::hex, std::oct
int pos_int {717171};
int neg_int {-47347};
double double_var {498.32};

std::cout << std::endl;
std::cout << "pos_int in different bases : " << std::endl;
std::cout << "pos_int (dec) : " << std::dec << pos_int << std::endl;
std::cout << "pos_int (hex) : " << std::hex << pos_int << std::endl;
std::cout << "pos_int (oct) : " << std::oct << pos_int << std::endl;

std::cout << std::endl;
std::cout << "neg_int in different bases : " << std::endl;
std::cout << "neg_int (dec) : " << std::dec << neg_int << std::endl;
std::cout << "neg_int (hex) : " << std::hex << neg_int << std::endl;
std::cout << "neg_int (oct) : " << std::oct << neg_int << std::endl;

std::cout << std::endl;
std::cout << "double_var in different bases : " << std::endl;
std::cout << "double_var (dec) : " << std::dec << double_var << std::endl;
std::cout << "double_var (hex) : " << std::hex << double_var << std::endl;
std::cout << "double_var (oct) : " << std::oct << double_var << std::endl;

std::cout << "\n-------------showbase--------------------------\n"
// std::showbase -> Shows the base prefix for integers when used with hex(0x) or oct (0).

//showbase and noshowbase : show the base for integral types
pos_int = 717171;

std::cout << "pos_int (noshowbase : default) : " << std::endl;
std::cout << "pos_int (dec) : " << std::dec << pos_int << std::endl;
std::cout << "pos_int (hex) : " << std::hex << pos_int << std::endl;
std::cout << "pos_int (oct) : " << std::oct << pos_int << std::endl;

std::cout << std::endl;

std::cout << "pos_int (showbase) :" << std::endl;
std::cout << std::showbase;
std::cout << "pos_int (dec) : " << std::dec << pos_int << std::endl;
std::cout << "pos_int (hex) : " << std::hex << pos_int << std::endl;
std::cout << "pos_int (oct) : " << std::oct << pos_int << std::endl;

std::cout << "\n--------------uppercase-------------------------\n"
// std::uppercase ->Outputs hexadecimal and scientific letters in uppercase. (e.g. 0X2A, 1.2E+03).

//uppercase and nouppercase
pos_int = 717171;

std::cout << "pos_int (nouppercase : default) : " << std::endl;
std::cout << "pos_int (dec) : " << std::dec << pos_int << std::endl;
std::cout << "pos_int (hex) : " << std::hex << pos_int << std::endl;
std::cout << "pos_int (oct) : " << std::oct << pos_int << std::endl;

std::cout << std::endl;
std::cout << "pos_int (uppercase) : " << std::endl;
std::cout << std::uppercase;
std::cout << "pos_int (dec) : " << std::dec << pos_int << std::endl;
std::cout << "pos_int (hex) :" << std::hex << pos_int << std::endl;
std::cout << "pos_int (oct) :" << std::oct << pos_int << std::endl;

std::cout << "\n-------scientific----------fixed------------\n"
// std::scientific -> Forces floating-point numbers to be displayed in scientific notation(e.g. 1.23e+03)
// std::fixed -> Forces floating-point numbers to be displayed in decimal(fixed-point) notation.

double a{ 3.1415926535897932384626433832795 };
double b{ 2006.0 };
double c{ 1.34e-10 };

std::cout << std::endl;
std::cout << "double values (default) : " << std::endl;
std::cout << "a : " << a << std::endl;
std::cout << "b : " << b << std::endl;
std::cout << "c : " << c << std::endl;

std::cout << std::endl;
std::cout << "double values (fixed) : " << std::endl;
std::cout << std::fixed;
std::cout << "a : " << a << std::endl;
std::cout << "b : " << b << std::endl;
std::cout << "c : " << c << std::endl;

std::cout << std::endl;
std::cout << "double values (scientific) : " << std::endl;
std::cout << std::scientific;
std::cout << "a : " << a << std::endl;
std::cout << "b : " << b << std::endl;
std::cout << "c : " << c << std::endl;

std::cout << std::endl;
std::cout << "double values (back to defaults) : " << std::endl;
std::cout.unsetf(std::ios::scientific | std::ios::fixed);
std::cout << "a : " << a << std::endl;
std::cout << "b : " << b << std::endl;
std::cout << "c : " << c << std::endl;


std::cout << "\n-----------------setprecision----------------------\n"
// std::setprecision(2) -> Sets the number of digits after the decimal for floating-point values(if fixed or scientific is used. )

//setprecision() : the number of digits printed out for a floating point. Default is 6
a = 3.1415926535897932384626433832795;

std::cout << std::endl;
std::cout << "a (default precision(6)) :" << a << std::endl;
std::cout << std::setprecision(10);
std::cout << "a (precision(10)) :" << a << std::endl;
std::cout << std::setprecision(20);
std::cout << "a (precision(20)) :" << a << std::endl;
std::cout << std::setprecision(50);
std::cout << "a (precision(50)) :" << a << std::endl;

//Reset precision to 6
std::cout << std::setprecision(6) << std::endl;

std::cout << "\n--------------showpoint-------------------------\n"
// std::showpoint -> Always shows the decimal point and trailing zeros in floating-point numbers(e.g. 5.00 instead of 5)

//showpoint and noshowpoint : show trailing zeros if necessary

double d {34.1};
double e {101.99};
double f {12.0};
int g {45};

std::cout << std::endl;
std::cout << "noshowpoint (default) : " << std::endl;
std::cout << "d : " << d << std::endl;
std::cout << "e : " << e << std::endl;
std::cout << "f : " << f << std::endl;
std::cout << "g : " << g << std::endl;

std::cout << std::endl;
std::cout << "showpoint: " << std::endl;
std::cout << std::showpoint;
std::cout << "d : " << d << std::endl;
std::cout << "e : " << e << std::endl;
std::cout << "f : " << f << std::endl;
std::cout << "g : " << g << std::endl;

std::cout << "\n------------setfill---------------------------\n"
// std::setfill(' ') -> Sets the fill character used when the field width is larger than the context. Default is space, but you can use '0', '*', etc.

std::cout << "\n-------------internal--------------------------\n"
// std::internal -> For numbers, aligns signs/prefixes to the elft, and digits to the right. (used with std::setw). Example: -123









std::cout << "\n---------------------------------------\n"
```