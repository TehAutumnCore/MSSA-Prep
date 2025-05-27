# Constructors
Class Constructor: A special kind of method that is called when an instance of a class is created.
    no return type
    same name as the class
    Can have parameters, Can also have an empty parameter list.
    Usually used to initialize member variables of a class.

```cpp
class Cylinder {

//properties
private : 
    double base_radius{1.0};
    double height{1.0};

//Behaviors
public:
    Cylinder(){
        base_radius = 2.0;
        height = 2.0;
    };
    Cylinder(double radius_param, double height_param) {
        base_radius = radius_param;
        height = height_param;
    }
    double volume() {
        return PI * base_radius * base_radius * height
    }
}
```