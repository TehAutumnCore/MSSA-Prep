// string message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine(result);

// if (message.Contains("fox")) {
//     Console.WriteLine("What does the fox say?");
// }


Random dice = new Random();
// int roll1 = dice.Next(1,7);
// int roll2 = dice.Next(1,7);
// int roll3 = dice.Next(1,7);
int roll1 = 4;
int roll2 = 4;
int roll3 = 4;

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

//implementing doubles or triplebonus
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
    //implementing tripe bonus
    if ((roll1 == roll2) && (roll2 == roll3)) {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total+=6;
    } else {
    //implementing doubles bonus
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total+=2;
    }
    Console.WriteLine($"Your total including the bonus is {total}!");
}



if (total >= 16) {
    Console.WriteLine("You win a new CAR!");
} 
else if (total >= 10) {
        Console.WriteLine("You win a new LAPTOP!");
}
else if(total == 7) {
    Console.WriteLine("You win a TRIP FOR TWO!");
}
else{
    Console.WriteLine("You won a kitten!");
}