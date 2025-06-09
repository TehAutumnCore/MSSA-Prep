using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalClasses
{
    class Animal
    {
        protected string name { get; set; } //protected makes it available to only derived classes, protected since dog class is using this attribute in its move method, this.name
        private bool _isAlive; //backing field to store actual data, stores the true/false
        protected bool isAlive //protected getter and setter for dog class
        {   //when asked for IsAlive, return whats stored in _isAlive
            get
            {
                return _isAlive;
            }
            set
            {
                _isAlive = value; //update backing field with new value
                if (_isAlive == false)
                {
                    Console.WriteLine($"{this.name} is no longer alive");
                }
                else
                {
                    Console.WriteLine($"{this.name} is well!");
                }
            }
        }
        private int weight { get; set; }
        public Animal()
        {
            Console.WriteLine("Animal Constructor");
        }

        public Animal(string name, bool isAlive, int weight)
        {
            this.name = name;
            this.isAlive = isAlive;
            this.weight = weight;
        }

        public void Greet()
        {
            Console.WriteLine("Animal Greet: Animal said 'hello'");
        }
        public void Talk()
        {
            Console.WriteLine("Animal Talk: Animal is talking");
        }
        public void Sing()
        {
            Console.WriteLine("Animal Sing: Animal is singing");
        }
        public virtual void Move() //virtual is so derived classes can manipulate its behavior
        {
            Console.WriteLine("This animal is levitating?!?!");
        }
        public override string ToString() //ToString inherited from System.Object
        {
            return $"Animal ToString(): name: {name}\tStatus: {isAlive},\tWeight: {weight}";
        }
    }












    class Dog : Animal, IDomesticated //inherits from Animal
    {                                       //
        public Dog(string name, bool isAlive, int weight) : base(name, isAlive, weight)
        {

        }
        public void Talk()
        {
            Console.WriteLine("Dog Talk: Bark Bark Bark");
        }
        public void Sing()
        {
            Console.WriteLine("Dog Sing: Howllll");
        }
        public override void Move() //override--overrides the behavior of the method inherited from another class
        {
            Console.WriteLine($"{this.name} started running using all 4 of its legs!");
        }
        public void SetAliveStatus(bool isAlive)
        {
            isAlive = isAlive;
        }
        public void PetMe()
        {
            Console.WriteLine("Please scratch behind my ear");
        }
        public void FeedMe()
        {
            Console.WriteLine("Dinner time! Best time of the day!");
        }
    }
    interface IDomesticated
    {
        void PetMe();
        void FeedMe();
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal beast = new Animal("beast", true, 100);

            beast.Greet();
            beast.Talk();
            beast.Sing();
            beast.Move();

            // beast.TouchMe();
            // beast.FeedMe();

            Console.WriteLine(beast.ToString());
            // Console.ReadLine();
            Console.WriteLine("");

            Dog fido = new Dog("fido", false, 25);
            fido.Greet();
            fido.Talk();
            fido.Sing();
            fido.Move();
            fido.SetAliveStatus(true);

            fido.PetMe();
            fido.FeedMe();

            Console.WriteLine(fido.ToString());
        }
    }
}
