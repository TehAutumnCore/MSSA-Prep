// void PrintMessage(string message) {
//     Console.WriteLine("Hello, World!");
// }

/*
double total = 0;
double minimumSpend = 30.00;

double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

total -= TotalMeetsMinimum() ? 5.00 : 0.00;

Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{
    return items[itemIndex] * (1 - discounts[itemIndex]);
}

bool TotalMeetsMinimum()
{
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    return input.ToString().Substring(0, 5);
}
*/
/*
double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");
Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

int UsdToVnd(double usd) 
{
    int rate = 23500;
    return (int)(rate*usd);
}

double VndToUsd(int vnd) {
    double rate = 23500;
    return vnd/rate;
}
*/
/*
using System;
using System.Text;

string input = "snake";

Console.WriteLine(input);
Console.WriteLine(ReverseWord(input));

string ReverseWord(string word) {
    string result = "";
    for(int i=word.Length - 1; i>=0; i--) {
        result += word[i];
    }
    return result;
}
//

string input2 = "there are snakes at the zoo";
Console.WriteLine(input2);
Console.WriteLine(ReverseSentence(input2));

string ReverseSentence(string input2) { 
    StringBuilder result = new StringBuilder();
    string[] words = input2.Split(" "); 

    foreach (string word in words) { //can also use the function ReverseWord(word) +" "
        char[] charArr = word.ToCharArray(); //make each word into an array
        Array.Reverse(charArr); //reverse each character
        string reversedWord = new string(charArr); //build a new string for each reversed word using the char arrays
        result.Append(reversedWord + " "); //append the reversed word with a space between each word
    }

    return result.ToString().TrimEnd(); //trims whitespace at end of string because of the append " " after each word.
}



string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};

Console.WriteLine("Is it a palidrome?");
foreach (word in words) {
    Console.WriteLine($"{word}: {IsPalidrome(word)}");
}

bool IsPalidrome(string word) {
    // return reverseWord(word) == word;
    int start = 0;
    int end = word.Length - 1;

    while (start < end) {
        if(word[start] != word[end]) {
            return false;
        }
        start++;
        end--;
    }
    return true;
}


int target = 30;
int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
int[,] result = TwoCoins(coins, target);

if (result.Length == 0) 
{
    Console.WriteLine("No two coins make change");
} 
else 
{
    Console.WriteLine("Change found at positions:");
    for (int i = 0; i < result.GetLength(0); i++) 
    {
        if (result[i,0] == -1) 
        {
            break;
        }
        Console.WriteLine($"{result[i,0]},{result[i,1]}");
    }
}

int[,] TwoCoins(int[] coins, int target) 
{
    int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
    int count = 0;

    for (int curr = 0; curr < coins.Length; curr++) 
    {
        for (int next = curr + 1; next < coins.Length; next++) 
        {    
            if (coins[curr] + coins[next] == target) 
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }
            if (count == result.GetLength(0)) 
            {
                return result;
            }
        }
    }
    return (count == 0) ? new int[0,0] : result;
}
*/

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay()) 
{
    PlayGame();
}

bool ShouldPlay() {
    string response = Console.ReadLine();
    return response.ToLower().Equals("y")
}

void PlayGame() 
{
    var play = true;

    while (play) 
    {
        var target = GetTarget();
        var roll = GetRoll();

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose());
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

int GetTarget() {
    return random.Next(1,6);
}

int RollDice() {
    return random.Next(1,7);
}

string WinOrLose(int roll, int target) 
{
    if (roll > target) 
    {
        return "You win!";
    }
    return "You lose!";
}