// do
// {
//     //This code will execute atleast one time
// } while (true);

// Random random = new Random();
/*
int current = 0;
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

/*
int current = random.Next(1, 11);
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
} Console.WriteLine($"Last number: {current}");
*/

// Random random = new Random();
// // int current = random.Next(1, 11);
// int current;

// do
// {
//     current = random.Next(1, 11);

//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } while (current != 7);


//Code Challenge - write code to implement the game rules
/*
    -You must use either the do-while statement or the while statement as an outer game loop.
    -The hero and the monster start with 10 health points.
    -All attacks are a value between 1 and 10.
    -The hero attacks first.
    -Print the amount of health the monster lost and their remaining health.
    -If the monster's health is greater than 0, it can attack the hero.
    -Print the amount of health the hero lost and their remaining health.
    -Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
    -Print the winner.
*/


//Initializing hp and  random
int heroHP = 10;
int monsterHP = 10;
Random randomDMG = new Random();
/* While loop
while (heroHP > 0 && monsterHP > 0)
{
    //rng damage
    int heroAttack = randomDMG.Next(1, 11);
    int monsterAttack = randomDMG.Next(1, 11);

    monsterHP -= heroAttack;
    Console.WriteLine($"Monster lost {heroAttack}HP and their remaining health is {monsterHP}");

    if (monsterHP <= 0)
    {
        Console.WriteLine("Hero wins!");
        break;
    }

    heroHP -= monsterAttack;
    Console.WriteLine($"Hero lost {monsterAttack}HP and their remaining health is {heroHP}");

    if (heroHP <= 0)
    {
        Console.WriteLine("Monster Wins!");
        break;
    }

}
*/
/* Do While
do
{
    int heroAttack = randomDMG.Next(1, 11);
    monsterHP -= heroAttack;
    Console.WriteLine($"Monster lost {heroAttack}HP and their remaining health is {monsterHP}");

    if (monsterHP <= 0) break; //continue skips the rest of the loop and jumps to the condition check then runs again, break exits loop immediately when one side wins.

    int monsterAttack = randomDMG.Next(1, 11);
    heroHP -= monsterAttack;
    Console.WriteLine($"Hero lost {monsterAttack}HP and their remaining health is {heroHP}");
} while (heroHP > 0 && monsterHP > 0);
Console.WriteLine(heroHP > monsterHP ? "Hero Wins!" : "Monster Wins!");
*/