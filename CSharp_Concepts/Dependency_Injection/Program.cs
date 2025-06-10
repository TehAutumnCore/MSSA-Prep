namespace DependencyInjectApp
{
    /*
    This project was created real quick to help me get more of an understanding of Dependency Injection, and at this time a Constructor Injection so I can learn CRUD with aspnet.
    
    Dependency injection is a programming technique that makes a class independent of its dependencies. This helps you follow SOLID's dependency inversion and single responsibility principles.
    
    Constructor Injection: Dependencies are provided through a class constructor ensuring that the class receives all its dependencies at the time of instantiation

            (TBD)Setter Injection: Dependencies are assigned to public setter methods allowing for the injection of dependencies after the object is created

            (TBD)Interface Injection: Dependencies are provided through an interfcae requiring the class to implement an interfca that exposes a method for injecting the dependency
    */

    public class Hammer 
    {
        public void Use() {
            Console.WriteLine("Hammering Nails!");
        }
    }

    public class Saw 
    {
        public void Use()
        {
            Console.WriteLine("Sawing Wood!");
        }
    }
    
    public class Builder
    {
        private Hammer _hammer;
        private Saw _saw;

        //Constructor Dependency Injection
        public Builder(Hammer hammer, Saw saw) 
        {
            // _hammer = new Hammer(); //Buider is responsible for creating its own dependencies
            // _saw = new Saw();
            _hammer = hammer;
            _saw = saw;
        }

        public void BuildHouse() 
        {
            _hammer.Use();
            Console.WriteLine("House built");

            _saw.Use();
            Console.WriteLine("Wood has been sawwed");
        }
    }

    internal class Program
    {
        static void Main(string[] args) {

            Hammer hammer = new Hammer();
            Saw saw = new Saw();
            Builder builder = new Builder(hammer, saw);

            builder.BuildHouse();
            Console.ReadLine();
        }
    }
}