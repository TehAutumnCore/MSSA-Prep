﻿/*
CountTo(5);

void CountTo(int max) {
    for (int i = 0; i < max; i++) {
        Console.WriteLine($"{i}, ");
    }
}

int [] schedule = {800,1200,1600,2000};

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT) {
    int diff=0;
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12) 
    {
        Console.WriteLine("Invalid GMT");
    }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    } 
    else 
    {
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }

    for(int i = 0; i < times.Length; i++) {
        int newTime = ((times[i] + diff)) % 2400;
        Console.WriteLine($"{times[i]} -> {newTime}");
    }
}

DisplayAdjustedTimes(schedule, 6, -6);
*/
/*
string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

DisplayStudents(students);
DisplayStudents(new string[] {"Robert","Vanya"});

void DisplayStudents(string[] students) 
{
    foreach (string student in students) 
    {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
}

void PrintCircleCircumference(int radius) 
{
    double pi = 3.14159;
    double circumference = 2 * pi * radius;
    Console.WriteLine($"Circumference = {circumference}");
}

void PrintCircleArea(int radius) {
    double pi = 3.14159;
    double area = pi*(radius * radius);
    Console.WriteLine($"Area = {area}");
}

double pi = 3.14159;
PrintCircleInfo(12);
PrintCircleInfo(24);

void PrintCircleInfo(int radius) {
    Console.WriteLine($"Circle with radius {radius}");
    PrintCircleArea(radius);
    PrintCircleCircumference(radius);
}
*/
/*
int a = 3;
int b = 4;
int c = 0;

Multiply(a,b,c);
Console.WriteLine($"Global statement: {a} x {b} = {c}");

void Multiply(int a, int b, int c) {
    
    c = a * b;
    Console.WriteLine($"Inside Multiply Method: {a} x {b} = {c}");
}
*/
/*
int[] array = {1,2,3,4,5};

PrintArray(array);
Clear(array);
PrintArray(array);

void PrintArray(int[] array) {
    foreach (int a in array) {
        Console.WriteLine($"{a} ")
    }
    Console.WriteLine();
}

void Clear(int[] array) {
    for (int i =0; i < array.Length; i++) {
        array[i] = 0;
    }
}
*/
/*
string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth(status, false);
Console.WriteLine($"End: {status}");

void SetHealth(string status, bool isHealthy) {
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
}
*/
/*
string status = "Healthy";

Console.WriteLine($"Start: {status}");
SetHealth(false);
Console.WriteLine($"End: {status}");

void SetHealth(bool isHealthy) {
    status = (isHealthy ? "Healthy" : "Unhealthy");
    Console.WriteLine($"Middle: {status}");
}
*/

string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
string[] rsvps = new string[10];
int count = 0;

RSVP("Rebecca");
RSVP("Nadia", 2, "Nuts");
RSVP(name: "Linh", partySize: 2, inviteOnly: false);
RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
RSVP("Noor", 4, inviteOnly: false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

void RSVP(string name, int partySize=1, string allergies="none", bool inviteOnly=true) {
    if (inviteOnly) {
        //search guestList befoore adding rsvp
        if(inviteOnly) {
            bool found = false;
            foreach(string guest in guestList) {
                if(guest.Equals(name)) {
                    found = true;
                    break;
                }
            }
            if (!found) {
                Console.WriteLine($"Sorry, {name} is not on the guest list");
                return;
            }
        }
    }
    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs() {
    Console.WriteLine("\nTotal RSVPs: ");
    for(int i = 0; i < count; i++) {
        Console.WriteLine(rsvps[i]);
    }
}

string[,] corporate = {
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external = {
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) {
    //display internal email address
    string firstName = corporate[i,0].Substring(0,2);
    string lastName = corporate[i,1];
    string corporateEmail = (firstName + lastName).ToLower() + "@contoso.com";
    Console.WriteLine(corporateEmail);
}

for (int i=0; i < external.GetLength(0);i++) {

    string firstName = external[i,0].Substring(0,2);
    string lastName = external[i,1];
    string externalEmail = (firstName + lastName).ToLower() + externalDomain;
    Console.WriteLine(externalEmail);
}


/* Output
    robavin@contoso.com
    sibright@contoso.com
    kisinclair@contoso.com
    aakamath@contoso.com
    sadelucchi@contoso.com
    siali@contoso.com
    viashton@hayworth.com
    codysart@hayworth.com
    shlawrence@hayworth.com
    davaldes@hayworth.com
*/