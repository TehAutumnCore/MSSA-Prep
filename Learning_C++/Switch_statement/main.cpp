#include <iostream>


int main() {
    
    const int Pen{ 10 };
    const int Marker{ 20 };
    const int Eraser{ 30 };
    const int Rectangle{ 40 };
    const int Circle{ 50 };
    const int Ellipse{ 60 };    
    
    int tool = -1;
    std::string input;
    
    while (tool == -1) {
        std::cout << "Please pick between a Pen, Marker, Eraser, Rectangle, Circle, or Ellipse" << std::endl;
        std::cin >> input;

        // int tool { Pen };
        if(input == "Pen") tool = Pen;
        else if(input == "Marker") tool = Marker;
        else if(input == "Eraser") tool = Eraser;
        else if(input == "Rectangle") tool = Rectangle;
        else if(input == "Circle") tool = Circle;
        else if(input == "Ellipse") tool = Ellipse;
        else{
            std::cout << "Please try a valid tool name\n";
        }
    }

    switch(tool) {
        case Pen: std::cout << "Active tool is Pen" <<std::endl; break;
        case Marker: std::cout << "Active tool is Marker" <<std::endl; break;
        case Eraser: std::cout << "Active tool is Eraser" <<std::endl;break;
        case Rectangle: std::cout << "Active tool is Rectangle" <<std::endl;break;
        case Circle: std::cout << "Active tool is Circle" <<std::endl;break;
        case Ellipse: std::cout << "Active tool is Ellipse" <<std::endl;break;
        default: std::cout << "Can't match any tool" << std::endl; //redundant because while loop handles non valid input
    }

    return 0;
}