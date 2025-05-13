// string firstName = "Bob";
// int widgetsSold = 7;
// /*
// Testing a change to the message
// int widgetsSold = 7l
// Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.")
// */
// Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");


/*
The following code creates five random OrderIDs
to test the fraud detection process. OrderIDs 
consist of a letter from A to E, and a three 
digit number. EX. A123.
*/
/*
Random random = new Random();
string[] orderIDs = new string[5];
for (int i = 0; i < orderIDs.Length; i++) {
    //Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65,70);
    //Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    //Create a random number, pad with zeroes
    string suffix = random.Next(1,1000).ToString("000");
    //Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}
//Print out each orderID
foreach (var orderID in orderIDs) { 
    Console.WriteLine(orderID);
}
*/

//improved utilizing a helper function
// using System;
// class Program
// {
//     static void Main() {
//         Random random = new Random();
//         string[] orderIDs = new string[5];
//         createOrderIDs(orderIDs,random);
        
//         foreach (var orderID in orderIDs) {
//             Console.WriteLine(orderID);
//         }
//     }

//     static void createOrderIDs(string[] orderIDs, Random random) {
//         for (int i = 0; i < orderIDs.Length; i++) {
//             int prefixValue = random.Next(65,70); //A-E
//             string prefix = Convert.ToChar(prefixValue).ToString();
//             string suffix = random.Next(1,1000).ToString("000");
//             orderIDs[i] = prefix + suffix;
//         }
//     }
// }


//Example 1:
// Console 
// .
// WriteLine
// (
//     "Hello Example 1"
// )
// ;

//Example 2
// string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+;lastWord+"!");



// Random dice = new Random();
// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;
// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}")

// if ((roll1 == roll2) || (roll2 = roll3) || (roll1 == roll3)) 
// {
//     if ((roll1 == roll2) && (roll2 == roll3)) 
//     {
//         Console.WriteLine("You rolled triples! +6 bonus to total!");
//     } 
//     else 
//     {
//         Console.WriteLine("You rolled doubles! +2 doubles to total!");
//         total += 2;
//     }
// }


/*
This code reverses a message, counts the number of times
a particular character appears, then prints the results
to the console window
*/
string str = "the quick brown fox jumps over the lazy dog";

char[] charMessage = str.ToCharArray():
Array.Reverse(charMessage);

int letterCount = 0;

foreach (char letter in charMessage) 
{ 
    if ( letter == 'o' ) 
    { 
        letterCount++; 
    } 
}

string new_message = new String(charMessage);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.")