#include <iostream>

int main() {
    
    const int Pen{ 10 };
	const int Marker{ 20 };
	const int Eraser{ 30 };
	const int Rectangle{ 40 };
	const int Circle{ 50 };
	const int Ellipse{ 60 };


    //else if clauses
    int tool{ Circle };

    if (tool == Pen) {
    	std::cout << "Active tool is pen" << std::endl;
    	//Do the actual painting
    }
    else if (tool == Marker) {
    	std::cout << "Active tool is Marker" << std::endl;
    }
    else if (tool == Eraser) {
    	std::cout << "Active tool is Eraser" << std::endl;
    }
    else if (tool == Rectangle) {
    	std::cout << "Active tool is Rectangle" << std::endl;
    }
    else if (tool == Circle) {
    	std::cout << "Active tool is Circle" << std::endl;
    }
    else if (tool == Ellipse) {
    	std::cout << "Active tool is Ellipse" << std::endl;
    }

    std::cout << "Moving On : " << std::endl;

    return 0;
}