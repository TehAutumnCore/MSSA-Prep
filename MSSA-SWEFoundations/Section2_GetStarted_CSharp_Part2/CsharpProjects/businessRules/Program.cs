/*
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here

if (daysUntilExpiration ==0) { 
    Console.WriteLine("Your subscription has expired.");
} else if (daysUntilExpiration == 1) {
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
} else if (daysUntilExpiration <= 5) {
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
} else if (daysUntilExpiration <=10) {
    Console.WriteLine("Your subscription will expire soon. Renew now!");
} else { //daysUntilExpiration > 10
    Console.WriteLine("display nothing");
}

if (discountPercentage > 0) {
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}
*/


using System;

class Program {
    static void Main() {
        Random random = new Random();
        int daysUntilExpiration = random.Next(12);

        //Call the refactored method to display subscription messages
        DisplaySubscriptionMessage(daysUntilExpiration);
    }
    static void DisplaySubscriptionMessage(int daysUntilExpiration) {
        int discountPercentage = 0;

        if (daysUntilExpiration == 0) {
            Console.WriteLine("Your subcription has expired.");
        }
        else if(daysUntilExpiration == 1){
            Console.WriteLine("Your subscription expires within a day!");
            discountPercentage = 20;

        }
        else if(daysUntilExpiration <= 5){
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
            discountPercentage = 10;

        }
        else if(daysUntilExpiration <= 10 ){
            Console.WriteLine("Your subscription will expire soon. Renew Now!");

        }
        else {
            Console.WriteLine("display nothing");
        }
        if (discountPercentage > 0) {
            Console.WriteLine($"Renew now and save {discountPercentage}%.");
        }
    }
}