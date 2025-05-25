#include <iostream>

int main(){
    bool a{true};    
    bool b{false};
    bool c{true};

    std::cout << std::boolalpha;

    std::cout << "a : " << a << std::endl; //true
    std::cout << "b : " << b << std::endl; //false
    std::cout << "c : " << c << std::endl; //true


    //AND: Evaluates to true when all operands are true.
    //A single false operand will drag
    //the entire expression to evaluating false.

    std::cout << std::endl;
    std::cout << "Basic AND operations" << std::endl;

    std::cout << " a && b : " << (a && b) << std::endl;//false
    std::cout << " a && c : " << (a && c) << std::endl;//true
    std::cout << " a && b : " << (a && b && c) << std::endl;//false


    //OR: Evaluates to true when atleast one operand true. 
    //A single true operand will push
    //The entire expression to evaluating true.

    std::cout << std::endl;
    std::cout << "Basic OR Operations" << std::endl;
    std::cout << " a || b : " << (a || b) << std::endl;//true
    std::cout << " a || c : " << (a || c) << std::endl;//true
    std::cout << " a || b || c : " << (a || b || c) << std::endl;//true

    //NOT : Negates whateve operand you put it with
    std::cout << std::endl;
    std::cout << "Basic NOT Operations" << std::endl;

    std::cout << "!a : " << !a << std::endl;//false
    std::cout << "!b : " << !b << std::endl;//true
    std::cout << "!c : " << !c << std::endl;//false

    //Combine Logical Operators in expression
    std::cout << std::endl;
    std::cout << "Combine Logical Operators in expression" << std::endl;
    std::cout << "!(a && b) || c : " << (!(a && b) || c) << std::endl; //true

    //Logical and Relational combined in expressions

    int d{45};
    int e{20};
    int f{11};

    std::cout << std::endl;
    std::cout << "Relational and logic operations on integers" << std::endl;
    std::cout << "d : " << d << std::endl;
    std::cout << "e : " << e << std::endl;
    std::cout << "f : " << f << std::endl;

    std::cout << std::endl;

    std::cout << "(d > e) && (d > f) : " << ((d > e) && (d > f)) << std::endl; //true
    std::cout << "(d == e) || (e <= f) : " << ((d == e) || (e <= f)) << std::endl; //false
    std::cout << "(d < e) || (d > f) : " << ((d < e) || (d > f)) << std::endl; //true
    std::cout << "(f > e) || (d < f) : " << ((f > e) || (d < f)) << std::endl; //false
    std::cout << "(d > f) && (f <= d) : " << ((d > f) && (f <= d)) << std::endl;//true
    std::cout << "(d > e) && (d <= f) : " << ((d > e) && (d <= f)) << std::endl;//false
    std::cout << "(!a) && (d == e) : " << ((!a) && (d == e)) << std::endl;//false
    std::cout << "(!a) && (d == e) : " << ((!a) && (d == e)) << std::endl;//false

}