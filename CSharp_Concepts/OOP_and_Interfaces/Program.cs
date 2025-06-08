using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    class Animal
    {
        string name{ get;set;}
        bool isAlive{get;set;}
        int weight{get;set;}
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }

        public Animal(string name,bool isAlive, int weight)
        {
            this.name = name;
            this.isAlive = isAlive;
            this.weight = weight;
        }

        public void Greet()
        {
            Console.WriteLine("Animal said 'hello'");
        }
        public void Talk()
        {
            Console.WriteLine("Animal is talking");
        }
        public void Sing()
        {
            Console.WriteLine("Animal is singing");
        }
        public string ToString() {
            return $"Animal ToString(): name: {name}\tStatus: {isAlive},\tWeight: {weight}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal beast = new Animal("beast",true, 100);

            beast.Greet();
            beast.Talk();
            beast.Sing();

            Console.WriteLine(beast.ToString());
            Console.ReadLine();
        }
    }
}
