namespace Classes
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hello {0}, I am {1}!", to, Name);
        }
        public static Person Parse(string str) //Parse is an instance method that has to be used on an object
        { //static so you dont have to create a person object first to Parse a string
            var person = new Person();
            person.Name = str;

            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //can use var
            // Person person = new Person(); before static
            // Person p = person.Parse("John"); before static 
            var person = Person.Parse("John"); //after static
            // person.Name = "John";
            person.Introduce("Gary");
        }
    }
}