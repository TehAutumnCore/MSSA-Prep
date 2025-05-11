// Random dice = new Random(); //creating a NEW instance of the random class and naming it dice. 
// Random dice = new(); //updated to simplify code readability in later version of the .NET Runtime
// int roll = dice.Next(1,7); //Next returns a random integer  between 1 and 6
// Console.WriteLine(roll);

// int result = Random.Next();
// Console.WriteLine(result);

// Random dice = new();
// int roll = dice.Next();

// int roll = dice.Next();
// Console.WriteLine(dice.Next(1,7));
// dice.Next(1,7);

// Random dice = new Random();
// int roll = dice.Next(1,7);
// Console.WriteLine(roll);

// int number = 7;
// string text = "seven";

// Console.WriteLine(number);
// Console.WriteLine();
// Console.WriteLine(text);

// Random dice = new Random();
// int roll1 = dice.Next(); //will return a number from 0 to 2,147,483,647
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50,101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// dice.Next()
// int roll1 = dice.Next()

int firstValue = 500;
int secondValue = 600;
int largerValue; 
Console.WriteLine(Math.Max(firstValue,secondValue));
