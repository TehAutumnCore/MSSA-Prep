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

