using System;
using System.Collections.Generic;

namespace Algorithms {
    class Employee {

        string name;
        int id;
        string department;

        public Employee(string name, int id, string department) {
            this.name = name;
            this.id = id;
            this.department = department;
        }

        static void Main(string[] args)
        {
            Employee employee = new Employee("Robby", 3827, "Technology");
            Employee employee2 = new Employee("Bobby", 9415, "Marketing");
            Employee employee3 = new Employee("Sally", 2519, "Sales");

            Dictionary<int, Employee> employeesByID = new(); //creates new dictionary called employeesByID
            employeesByID.Add(employee.id, employee); //Adds 
            employeesByID.Add(employee2.id, employee2);
            employeesByID.Add(employee3.id, employee3);

            Employee e; //gives Employee class an alias so it can be referred to as e
            if (employeesByID.TryGetValue(9415, out e)) // TryGetValue will attempt to pull the key value pair using the value of 9415 and will assign it to the variable e
            { //can also do employeeByID.TryGetValue(9415, out employee e) to assign the value to e using inline
                Console.WriteLine(e.name + " : " + e.department); //prints the employee's name using the value 9415, and their department. 
            } //searches the employee class's object assigned to the value of 9415.

            // employeesByID.ContainsKey(""); //returns true if key exist

            HashSet<string> productCodes = new();
            productCodes.Add("8F26B"); //adds key to HashSet
            productCodes.Add("0A43P"); //adds key to HashSet
            productCodes.Add("J2H762");//adds key to HashSet

            productCodes.Contains("48DB9"); //returns false because does not exist
            productCodes.Contains("J2H762"); //returns true
        }
    }
}