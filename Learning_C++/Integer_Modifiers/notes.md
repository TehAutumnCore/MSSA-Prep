# Integer Modifiers
Positive and negative numbers

*Note: These modifiers only apply to integral types : those in which you can store decimal numbers*

    int: Default integer type, signed by default meaning it can stores both positive and negative numbers
        int a = -10;
    
    signed int(default int; int is just shorter): Explicit way to say the variable can hold negative and positive values; same as writing int
        Signed range: [-2^n-1 ~ 2^n-1 -1]  (n being the number of bits for a type in memory)
        bytes in memory: 4   Range: [-2,147,483,648,  2,147,483,647]
        signed int b = -20;
        Temperatures(-30C to 40C)
        Bank account balances(overdraft = negative)
        Physics simulations (velocity in different locations)
    
    unsigned int: Can holy only positive numbers (including 0); doubles the positive range compared to int because it does allocate bits for negatives.
        unsigned range: [0~2^n-1] (n being the number of bits for a type in memory)
        bytes in memory: 4   Range: [0, 4,294,967,295]
        unsigned int c = 20;
        Array indices
        Sizes and counts(e.g., std::size_t, vector.size())
        Memory addresses or bitmasks

Examples:
int value1 {10};
int value1 {10};

signed int value2 {-300};
signed int value2 {-300};

unsigned int value2 {-300};
unsigned int value2 {-300};

# Table for short and long variable 
short short_var {-32768} ; // 2 Bytes
short int short_int {455} ; //
signed short signed_short {122}; //
signed short int signed_short_int {-456}; //
unsigned short int unsigned_short_int {456};

int int_var {55} ; // 4 bytes
signed signed_var {66};//
signed int signed_int {77};//
unsigned int unsigned_int{77};

long long_var {88}; // 4 OR 8 Bytes
long int long_int {33};
signed long signed_long {44};
signed long int signed_long_int {44};
unsigned long int unsigned_long_int{44};

long long long_long {888};// 8 Bytes
long long int long_long_int {999};
signed long long signed_long_long {444};
signed long long int signed_long_long_int{1234};
unsigned long long int unsigned_long_long_int{1234};