# Classes
##  What is a class
A building block of an application
## Real world example 
Presentation:
Business Logic/Domain:
Data Access/Persistance:
## Anatomy of a class
Data(represented by fields)
Behaviour(represented by methods/functions)
## Object
Person
<!-- Attributes -->
Name: string
Age: byte
Height: float
Weight: bye
<!-- Class Methods -->
Walk()
Talk()
Eat()
Sleep()

Post
<!-- Attributes/Fields -->
Title: string
Description: string
DateTime: DateTime
<!-- Methods -->
Publish()
Like()
Comment(message)

Object: An instance of a class
John
Mary
Scott
## Declaring classes
public - access modifier
class - keyword that signifies defining a class
Person - name of the class
public class Person {
    public string Name; <!--should use private, public is bad practice-->
    <!-- access notifier, return type and an identifier-->
    public void Introduce() { <!--Method-->
        Console.WriteLine("Hi, my name is" + Name);
    }
}

Naming Conventions:
Pascal Case: first letter of word is capital 
camel Case:  first letter of second word is capital
## Creating objects
Person person = new Person();
var person = new Person();
## Using Objects
<!-- access methods and attributes using dot notation-->
var person = new Person();
person.Name = "Gary";
person.Introduce();
## class members
Instance: accessible from an object.
    var person = new Person();
    person.Introduce();
Static: Accessible from the class
    Console.WriteLine();
    <!-- Console is a class, and WriteLine is a method -->
## Why use static members
To represent concepts that are singleton (one instance of that concept in the memory)
DateTime.Now <!--shouldnt be other places in the memory where different objects are telling you current DateTime is a different value  -->
Console.WriteLine()
## Declaring static members
public class Person{
    <!-- use static mon any members of a class -->
    public static int PeopleCount = 0;
}
##  Demo

