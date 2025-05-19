using System;
using System.Collections.Generic;
// FourPillarsOfOOP
namespace Abstraction{

    public class Person{
        //Private field: hideen from outside
        private string name;

        //Public property: access to the private field with get and set
        public string Name {get;set;}
        /*
        {
            get{return name;}
            set{name = value;}
        }
        */
        //You can also add validation in the setter
        private int age;

        public int Age{
            // get{return age;}
            get => age;
            set{
                if (value < 0)
                    throw new ArgumentException("Age cannot be negative");
                age = value;
            }
        }
        //Constructor to initialize the object
        public Person(string name, int age) {
            Name = name;
            Age = age;
        }
    }

    public class Car 
    {
        private string make;
        public string Make{get;set;}
        /*
        {
            get{return make;}
            set{make = value;}
        }
        */

        private int year;
        public int Year
        {
            // get{return year;}
            get => year;
            set
            {
                if(value < 1886)
                    throw new ArgumentException("Year cannot be before 1886.");
                year = value;
            }
        }
        public Car(string make, int year){
            Make = make;
            Year = year;
        }
        public override string ToString() { //python __str__ or __repr__ equivalent
            return $"Make: {Make}, Year: {Year}";
        }
    }

    public class Program {
        public static void Main(string[] args) {
            //testing person
            Person alice = new Person("Alice",30);
            Console.WriteLine(alice.Name); //Output: Alice
            alice.Age = 35; //update age
            //person.Age = -5; //throws an error because of validation
            
            //testing car
            Car myCar = new Car("Toyota",2016);
            Console.WriteLine($"Make: {myCar.Make}, year: {myCar.Year}");
            Console.WriteLine(myCar);
        }
    }
}



namespace Inheritance {
    public class Animal {
        //Private Fields
        private string name;
        private string color;

        //public properties for encapslation
        public string Name {get; init;} //name can only be set during object construction or an initalizer, great for immutable data, can use set; if you want mutability.
        /*
        {
            get{return name;}
            set{name = value;}
        }
        */

        public string Color {
            get{return color;}
            set{color = value;}
        }
        //Constructor
        public Animal(string name, string color) {
            Name = name;
            Color = color;
        }

        public virtual void Talk() {
            Console.WriteLine("Animal Sound");
        }
        
        public virtual void Walk() {
            Console.WriteLine($"{Name} is walking");
        }
    }

    //Derived class Cat inherits Animal
    public class Cat : Animal { //cat inherits from animal using :
        public Cat(string name, string color) : base (name, color) {
        }

        //cat uses inherited walk method, so no override here
        public override void Talk() {
            Console.WriteLine($"{Name} said meow");
        }
    }
    //Derived class Bird inherits Animal
        public class Bird : Animal {
            public Bird(string name, string color) : base(name, color) {
        }
    
    //override Walk to indicate Bird doesn't walk much..
        public override void Walk() {
            Console.WriteLine($"{Name} doesn't walk, it flies.");
        }

    //override talk to tweet
        public override void Talk() {
            Console.WriteLine($"{Name} Tweeted");
        }

    //new method unique to bird
        public void Fly() {
            Console.WriteLine($"{Name} is flying");
        }
    }

    class Program {
        public static void Main(string[] args) {

        Animal genericAnimal = new Animal("GenericAnimal", "Gray");
        genericAnimal.Talk(); //animal sound
        genericAnimal.Walk(); //genericanimal is walking

        Cat mittens = new Cat("Mittens", "Gray and White");
        mittens.Talk();
        mittens.Walk();

        Bird twitter = new Bird("Twitter", "Yellow");
        twitter.Talk();
        twitter.Walk();
        twitter.Fly();
        }
    }
}


namespace Encapsulation {
    public class BankAccount {
        //private field(not accessible outside directly)
        private decimal balance;

        //public property to read balance(no setter -read only)
        public decimal Balance{
            get => balance;
        }
        
        public string Owner {get; private set;}

        //Constructor
        public BankAccount(string owner, decimal initialDeposit) {
            if (initialDeposit < 0)
                throw new ArgumentException("Initial deposit cannot be negative");
            Owner = owner;
            balance = initialDeposit;
        }

        public void Deposit(decimal amount) {
            if(amount <= 0)
                throw new ArgumentException("Deposit must be greater than 0");
            balance += amount;
        }

        public void Withdraw(decimal amount) {
            if(amount <= 0)
                throw new ArgumentException("Withdrawal must be greater than 0");
            if(amount > balance)
                throw new InvalidOperationException("Insufficient funds.");
            balance -= amount;
        }

        public override string ToString() {
            return $"{Owner}'s balance is {balance:C}";
        }
    }

    class Program{
        static void Main(string[] args) {
            BankAccount account = new BankAccount("Alice", 1000);
            account.Deposit(500);
            account.Withdraw(200);

            Console.WriteLine(account); //Alice's balance is 1300
        }
    }
}

namespace Polymorphism {
    public class Animal{
        public string Name {get;set;}

        public Animal(string name) {
            Name = name;
        }

        public virtual void Speak() {
            Console.WriteLine($"{Name} makes a sound");
        }
    }

    public class Dog : Animal {
        public Dog(string name) : base(name) {}

        public override void Speak() {
            Console.WriteLine($"{Name} says Woof!");
        }
    }

    public class Cat : Animal {
        public Cat(string name) : base(name) {
        }

        public override void Speak() {
            Console.WriteLine($"{Name} says Meow!")
        }
    }
        class Program {
            static void Main(string[] args) {
                List<Animal> animals = new List<Animal>{
                new Dog("Rex"),
                new Cat("Whiskers"),
                new Animal("Creature")
            };

            foreach(var animal in animals) {
                animal.Speak();
            }
        }
    }
}