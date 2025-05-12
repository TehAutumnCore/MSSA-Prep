/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0]= "A123";
fraudulentOrderIDs[1]= "B456";
fraudulentOrderIDs[2]= "C789";

// fraudulentOrderIDs[3]= "D000";
// will receive outside the boundary of array runtime error if you try to access an element that doesnt exist
// Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array
*/

// string[] fraudulentOrderIDs = ["A123","B456","C789" ];

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");


// fraudulentOrderIDs[0] = "F000";
// Console.WriteLine($"Reassigned First: {fraudulentOrderIDs[0]}");

// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// using System;
// using System.Linq;

// string[] names = {"Rowena","Robin","Bao"};
// foreach (string name in names) {
//     Console.WriteLine(name);
// }




// Console.WriteLine("----------------------------");
// Console.WriteLine("using iterating and incrementing with foreach");

// int[] inventory = {200, 450, 700, 175, 250};

// int sum = 0;
// int bin = 0;
// foreach (int items in inventory) {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin: {bin} = {items} items (Running Total: {sum})");
// }
// Console.WriteLine($"We have {sum} items in inventory.");


/*
Console.WriteLine("----------------------------");
Console.WriteLine("using Sum() from System.Linq");

int total = inventory.Sum();
// Console.WriteLine(total);
Console.WriteLine($"We have {total} items in inventory.");
*/


// string name = "Bob";
// if (name.StartsWith("B")) {
//     Console.WriteLine("The name starts with 'B"!);
// }



string[] orderIDs = ["B123","C234","A345","C15","B177","G3003","C235","B179"];

int count = 0;
Console.WriteLine("The items starting with 'B'!");
foreach (string orderID in orderIDs) {
    if(orderID.StartsWith('B')) {
        count++;
        Console.WriteLine($"Item number {count}: {orderID}");
    }
}