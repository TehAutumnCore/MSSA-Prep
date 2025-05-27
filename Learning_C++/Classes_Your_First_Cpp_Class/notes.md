# Classes - Your First C++ class

```cpp

unsigned int age{44};
double score{55.8}

//Class syntax:
class Cylinder { //class keyword, name of class
    public: 
        double base_radius {1.0}; //member variables(properties)/attributes
        double height {1.0};

    public : 
        double volume() { //function
            return PI * base_radius * base radius * height;
        }
};

int main(int argc, char **argv) {
    //Using class instances(objects)
    Cylinder cylinder1;
    std::cout << "volume c1 : " << cylinder1.volume() << std::endl;

    cylinder1.base_radius = 3.0;
    cylinder1.height = 2;
    std::cout << "volume c1 : " << cylinder1.volume() << std::endl;

    Cylinder cylinder2;
    std::cout << "volume c2 : " << cylinder2.volume() << std::endl;

    return 0;
}
```

```cpp
int main(int argc, char **argv) {
    Cy
}

```