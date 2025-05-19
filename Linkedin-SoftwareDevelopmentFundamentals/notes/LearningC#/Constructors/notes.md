# C# Constructors
## What is a constructor?
A method that is called when an instance of a class is created.
## Why?
To put an object in an early state.
## How?
<!-- constructor has the exact same name as a class, and do not have a return type to include void-->
<!--  -->
```Csharp
public class Customer {
    public string Name;

    public Customer(string name){ //<!--Initializes the fields of the class to their default values-->
        this.Name = name; //C# equivalent of self.Name = name;
    }

class Program {
    public void Main(string[] args) {
        Console.WriteLine("Hello World");
        var customer = new Customer("Gary");
    }
}

}
```
## Constructor Overloading
To have a method by the same name but different signatures. A signature is what uniquely identifies a method.
To make initialization of a class easier, as we may only have the name so we may only use the second constructor when creating an instance of this class, or we may only know both the ID and name so we use the last constructor.
```Csharp
public class Customer {
    public Customer(){ //no parameter

    }
    public Customer(string name) { //takes one parameter

    }
    public Customer(int id, string name) { //takes two parameters

    }
}

```