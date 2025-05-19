using System;
using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class Order{
        public int orderId;
        public string OrderName;

        public Order(){
            
        }
    }

    public class Customer{ //open class in another cs file.
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer() { //default constructor
            Orders = new List<Order>(); //initalized as empty
        }
    
        public Customer(int id)
            :this() {//when this constructor is called, is first going to call the constructor without parameters so we dont need to copy and paste list into every constructor
            this.Id = Id;
        }
        public Customer(int id, string name) 
            :this(id) { //whent his constructor is called, it will call the constructor that takes the id parameter first
            // this.Id = id;
            this.Name=name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Customer customer = new Customer();
            var customer = new Customer(1,"Gary");
            var customer2 = new Customer();
            customer2.Id = 1;
            customer.Name = "John";

            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            
        }
    }
}