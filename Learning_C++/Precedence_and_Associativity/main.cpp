#include <iostream>

int main() {
    int a {6};
    int b {3};
    int c {8};
    int d {9};
    int e {3};
    int f {2};
    int g {5};

    int result = a + b * c -d/e - f + g; //6 + 24 -  3-2+5
    std::cout << "result : " << result << std::endl; //30

    //PEMDAS
    result = a/b*c +d - e + f; // 19 + 9 - 3 + 2
    std::cout << "result : " << result << std::endl;//24
    
    result = a + (b * c) - (d/e) -f + g;
    std::cout << "result : " << result << std::endl;//30
    
    result = (a + b) * c -d/e -f + g;
    std::cout << "result : " << result << std::endl;//72

    return 0;
}