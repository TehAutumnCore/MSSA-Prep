// string[] pallets = ["B13", "A11", "B12", "A13"];

// Console.WriteLine("Sorted..");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"--{pallet}");
// }

// string[] pallets = ["B14", "A11", "B12", "A13"];

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"--{pallet}");
// }

// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"--{pallet}");
// }

// string[] pallets = ["B14", "A11", "B12", "A13"];
// Console.WriteLine("");

// Console.WriteLine($"Before: {pallets[0]} {pallets[1]}"); //{pallets[0].ToLower()} -> Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
// Array.Clear(pallets, 0, 2); //removes start(0), and end(2), with null taking their place.

// if (pallets[0] != null)
// {
//     Console.WriteLine($"After: {pallets[0]} {pallets[1]}");
// }

// Console.WriteLine($"Clearing 2... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"--{pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"--{pallet}");
// }

// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets) {
//     Console.WriteLine($"--{pallet}");
// }

/*
string value = "abc123";
char[] valueArray = value.ToCharArray(); // [a,b,c,1,2,3]
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = string.Join(",", valueArray);
Console.WriteLine(result);


string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}
*/
/*
string pangram = "The quick brown fox jumps over the lazy dog";
string[] words = pangram.Split(' '); // [The,quick,brown,fox,jumps,over,the,lazy,dog]

for (int i = 0; i < words.Length; i++) //foreach is read only, for allows to modify each word by index
{
    char[] letters = words[i].ToCharArray(); //converts word into char array -> word[0] ->[t,h,e]   word[1] ->[q,u,i,c,k]  word[2] ->[b,r,o,w,n]  word[3] ->[f,o,x]
    Array.Reverse(letters); // t,h,e -> e,h,t
    words[i] = new string(letters); //converts reversed letters into a string -> e,h,t -> eht
}
string result = string.Join(" ", words);//combines each element at " "
Console.WriteLine(result);
*/
/*
string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split(' ');

for (int i = 0; i < words.Length; i++)
{
    words[i] = new string(words[i].Reverse().ToArray());
}
string result = string.Join(" ", words);
Console.WriteLine(result);
*/
/*for loop
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string splitOrderStream = new string(orderStream);
string[] words = splitOrderStream.Split(",");
Array.Sort(words);

for (int i = 0; i < words.Length; i++) {
    if (words[i] == "C15" || words[i] == "G3003")
    {
        Console.WriteLine($"{words[i]}  --Error");
    }
    else
    {
        Console.WriteLine(words[i]);
    }
}
*/

/*foreach
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(',');
Array.Sort(items);

foreach (var item in items)
{
    if (item.Length == 4)
    {
        Console.WriteLine(item);
    }
    else
    {
        Console.WriteLine(item + "\t- Error");
    }
}
*/

/* Output
    A345
    B123
    B177
    B179
    C15     - Error
    C234
    C235
    G3003   - Error
*/