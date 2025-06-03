// string first = "Hello";
// string second = "World";

// string result = string.Format("{0}{1}!", first, second)
// Console.WriteLine(result);

// string first = "Hello";
// string second = "World";
// Console.WriteLine("{1} {0}!", first, second);
// Console.WriteLine("{0} {0} {0}!", first, second);

// string first = "Hello";
// string second = "World";
// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");


// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// decimal measurement = 123456.78912m; 
// Console.WriteLine($"Measurement: {measurement:N} units"); //numeric format, so 123,456.79

// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N4} units");//N4 is precision

// Formatting percentages
// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}"); //P - format percentages and rounds 2 decimal places

// Combining formatting approaches
// decimal price = 67.55m;
// decimal salesPrice = 59.99m;

// string yourDiscount = string.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salesPrice), price);

// yourDiscount += $"A discoutn of {((price - salesPrice) / price):P2}!"; //inserted
// Console.WriteLine(yourDiscount);
/*
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2760.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"  Shares: {productShares:N3} Product");
Console.WriteLine($"    Sub Total: {subtotal:C}");
Console.WriteLine($"      Tax: {taxPercentage:P2}");
Console.WriteLine($"    Total Billed: {total:C}");
*/

//PadLeft(), PadRight() - formatting purposes
//Trim(), TrimStart(), TrimEnd(), GetHashCode(), Length - compare two strings or faciliate comparison
//StartsWith(), EndWith(), Substring() - helps determine whats inside of a string, or retrieve just a part of the string
//Replace(), Insert9), Remove() - replacing, inserting, orremoving parts
//Split(), ToCharArray() - Turn a string into an array of strings or characters

// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// Console.WriteLine(result);

// string input = "Pad this";
// Console.WriteLine(input.PadLeft(12,'-'));
// Console.WriteLine(input.PadRight(12,'-'));

// string paymentId = "769C";
// var formattedLine = paymentId.PadRight(6);

// Console.WriteLine(formattedLine);
//  string paymentId = "769C";
//  string payeeName = "Mr. Stephen Ortega";
//  string paymentAmount = "$5,000.00";

//  var formattedLine = paymentId.PadRight(6);
//  formattedLine += payeeName.PadRight(24); //can also do Console.WriteLine($"{value,10}")
//  formattedLine += paymentAmount.PadLeft(10);//can also do Console.WriteLine($"{value,10}") and add precision to it as well so {value,10:C2}

//  Console.WriteLine("1234567890123456789012345678901234567890");
//  Console.WriteLine(formattedLine);


//Exercise:

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here

Console.WriteLine(comparisonMessage);

Console.WriteLine($"""
Dear {customerName},
As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own {currentShares:C2} shares at a return of {currentReturn:P2}.

Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C2}.

Here's a quick comparison:

{currentProduct,-15} {currentReturn,10:P2} {currentProfit,15:C2}
{newProduct,-15} {newReturn,10:P2} {newProfit,15:C2}

""");


/*Output expectation

Dear Ms. Barros,
As a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.

Currently, you own 2,975,000.00 shares at a return of 12.75%.

Our new product, Glorious Future offers a return of 13.13%.  Given your current volume, your potential profit would be ¤63,000,000.00.

Here's a quick comparison:

Magic Yield         12.75%   $55,000,000.00      
Glorious Future     13.13%   $63,000,000.00

*/
