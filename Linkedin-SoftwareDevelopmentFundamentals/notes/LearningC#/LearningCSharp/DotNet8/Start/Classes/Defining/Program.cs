﻿using System;

namespace Defining
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Create new object instances using the "new" operator
            Book b1 = new Book("War and Peace", "leo Tolstoy", 825);
            Book b2 = new Book("The Grapes of Wrath", "John Steinbeck", 464);
            
            // TODO: Call a method on the object
            Console.WriteLine(b1.GetDescription());
            Console.WriteLine(b2.GetDescription());


            // TODO: try to set one of the properties -- 
            // this will result in an error
            // b1._name = "Aldous Huxley"; unable to change due to protection level.
        }
    }
}
