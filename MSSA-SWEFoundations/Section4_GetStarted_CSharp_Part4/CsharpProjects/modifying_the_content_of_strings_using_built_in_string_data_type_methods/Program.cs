/*
string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>"; 
const string closeSpan = "</span>";
// Console.WriteLine(openSpan); //<span>
// Console.WriteLine(closeSpan); //</span>

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

// Console.WriteLine(openingPosition);//18
// Console.WriteLine(closingPosition);//40

// Console.WriteLine(openingPosition);
openingPosition += openSpan.Length;//18 + 6 = 24 //updates openingPosition
// Console.WriteLine(openingPosition);

int length = closingPosition - openingPosition; //40-24=16
Console.WriteLine(length);//16
messageSubStr = message.Substring(openingPosition, length); // (start,start+16) 24,16
Console.WriteLine(messageSubStr);
*/

// string message = "hello there!";

// int first_h = message.IndexOf('h');
// int last_h = message.LastIndexOf('h');

// Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

// string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// int openingPosition = message.LastIndexOf('(');

// openingPosition += 1;
// int closingPosition = message.LastIndexOf(')');
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

/*
string message = "(What if) there are (more than) one (set of parentheses)?";
while (true)
{//base cases
    int openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break; //if we reach the end of the string break loop

//recursive case
    openingPosition += 1; //increment index of ( by 1 to get the character after
    int closingPosition = message.IndexOf(')'); //find the index of the )
    int length = closingPosition - openingPosition; //subtract the closingposition and opening position to get the distance from the closing and opening bracket
    Console.WriteLine(message.Substring(openingPosition, length)); //print the substring of the characters betwen the opening and opening+length to get the character before the )

    //Note the overload of the Substring to return only the remaining
    //unprocessed message:
    message = message.Substring(closingPosition + 1); //substring is created from the message to create a new message starting from the character after the )
}
*/
/*
string message = "Hello, world!";
char[] charsToFind = { 'a', 'e', 'i' };

int index = message.IndexOfAny(charsToFind);

Console.WriteLine($"Found '{message[index]}' in '{message}' at index: '{index}'. ");
*/

// string message = "Help (find) the {opening symbols}";
// Console.WriteLine($"Searching THIS Message: {message}");
// char[] openingSymbols = { '[', '{', '(' };
// int startPosition = 5;
// int openingPosition = message.IndexOfAny(openingSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openingSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPosition {startPosition}: {message.Substring(openingPosition)} ");
/*
string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

//The IndexOfAny() helper method requires a char array of characters.
//You want to look for:

char[] openSymbols = { '[', '{', '(' };

//You'll use a slightly different technique for iterating through
//The characters in the string. This time, use th eclosing
//position of hte previous iteration as the starting index for the 
//next open symbol.So you need to initialize the closingPosition
//variable to zero"

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition); //find the index of the first open symbol and last symbol
    if (openingPosition == -1) break; //if we reach  the end of the string break the loop

    string currentSymbol = message.Substring(openingPosition, 1); //create a substring using the index from the first bracket and taking one character over from it.

    // Now find the matching closing symbol
    char matchingSymbol = ' '; //empty variable to store the matching symbol

    switch (currentSymbol)
    {
        case "[": //if the current symbol is a [ make the matching symbol a ]
            matchingSymbol = ']';
            break; 
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ")";
            break;
    }
    //To find the closingPosition, we use an overload of the IndexOf method to specify
    //That the search for the matching Symbol should start at the openingPosition in the string.

    openingPosition += 1; //the first character will be after the 
    closingPosition = message.IndexOf(matchingSymbol, openingPosition); // matching symbol (']',27) //27 is where to start searching for the matchingsymbol from.

    //Finally, we use the techniques I've already learned to display the sub-string
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}
*/

// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);

// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";
/*Solution 1
//Your work here
int spanStart = input.IndexOf("<span>");
spanStart += 6;

int spanEnd = input.IndexOf("</span>");
int length = spanEnd - spanStart;

quantity = input.Substring(spanStart, length);


output = input.Replace("<span>", "").Replace("</span>", "");
*/
/*Solution 2: Better*/
int spanStart = input.IndexOf("<span>");//29
int spanEnd = input.IndexOf("</span>");//39

//Validate that both tags exist and are in the correct order.
if (spanStart != -1 && spanEnd != -1 && spanEnd > spanStart)
{
    spanStart += "<span>".Length;//29+6=35 -> Move past the <span> tag

    int length = spanEnd - spanStart; //39-35 = 4
    quantity = input.Substring(spanStart, length); //(35+4) = 39 "5000"

    //Remove span tags from the original input
    output = input.Replace("<span>", "").Replace("</span>", "");

}


Console.WriteLine($"quantity: {quantity}");
Console.WriteLine($"output: {output}");

// Quantity: 5000
// Output: <h2>Widgets &reg;</h2><span>5000</span>