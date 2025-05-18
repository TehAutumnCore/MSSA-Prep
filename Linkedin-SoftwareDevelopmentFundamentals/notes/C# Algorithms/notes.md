# C# Algorithms
# Introduction
## Improve your C# applications with efficient algorithms
Understanding Algorithms: Learn what makes an algorithm effective and how to optimize them for better performance.
Data Structures: Gain insights into working with various data structures like strings, arrays, linked lists, queues, stacks, hash-based structures, and trees.
Practical Applications: Apply algorithms to real-world problems using C# through hands-on practice and coding challenges.

## Introducing CoderPad Challenges
Interactive Code Challenges: The course includes interactive coding challenges hosted by CoderPad, allowing you to practice and test your solutions directly within the course.
Challenge Structure: Each challenge has four main areas: Instructions, a console for output, a code editor for your answer, and another code editor to see how your code is used.
Support Features: You can use features like "ShowExpectedResult" and "ShowHints" to get hints and see expected results if you get stuck.

Find the largest number in an array:
public static int FindLargest(int[] nums) {
    return nums.Max();
}

## What is an algorithm
Definition: An algorithm is a series of defined instructions that perform a specific task.
Step-by-Step process: Just like making a sandwich, every step in an algorithm must be clearly laid out for a computer to execute
Efficiency: Different set of instructions can achieve the same task, but some are more efficient than others.

## How to optimize an algorithm
Efficiency through Assumptions: Making informed assumptions about your data(e.g. assuming data is sorted or contain specific types) can help optimize algorithms by skipping unecessary steps.
Importance of Correct Assumptions: Incorrect assumptions can lead to unreliable algorithms. It's crucial to understand and verify the assumptions your algorithms is making.
Balance Between Speed and Accuracy: A slower, reliable algorithm is preferable to a faster one that produces incorrect results.

## Optimize an algorithm in C#
Initialize a max variable: Start by setting the max variable to the value of the first number (A).
Compare and update: Compare the second number (B) with the max variable. If B is greater, update the max variable to B.
Final comparison: Compare the third number (C) with the max variable. If C is greater, update the max variable to C.
Return the max value: The max variable now holds the maximum value of A, B, and C.

## How to describe the time complexity of an algorithm
Big-O Notation: A way to measure how the time or space an algorithm takes grows as the input size increases. This is used to describe the efficiency of an algorithm by comparing its performance independent of input size. It helps in understanding the best, average, and worse-case. scenarios.
Common Time Complexities: The video covers different types of time complexities such as:
    Constant Time: O(1)
        The time doesn't change with input size.
        Example: Checking the first item in a list, or the last item in the list
        Analogy: Looking at the top card
    Linear Time: O(N)
        The time grows diretly with the input size.
        Example: Searching through a list of N items.
        Analogy: Going through each card one by one.
    Logarithmic Time: O(log N)
        The time grows slowly as the input size increases.
        Example: Binary search in a sorted list
        Analogy: Spliting the deck in half repeatedly to find a card
    Quadratic Time: O(N^2)
        The time grows rapidly with the input size.
        Example" Comparing every pair of items in a list
        Analogy: Comparing each card with every other card.
    Factorial Time: O(n!)
        When an algorithm's time complexity grows extremely fast with the input size. Generally impractical for large inputs due to their extremely high growth rate. Often encountered in combinatorial problems and certain recursive algorithms.
        Example: A traveling salesman problem using brute force, where you try every possible route.
Space Complexity: Besides time complexity, Big-O Notation can also describe space complexity, indicating how much memory an algorithm uses relative to the input size. 

# String Algorithms
## Validate strings in C#
Validation Algorithms: check if a string has certain properties such as all uppercase, all lowercase, contains only letters or digits, and return a boolean (true or false)
Using Linq: Using linq to create compact and readable validation functions, such as checking if all characters in a string are uppercase or lowercase.
Password Complexity: Creating a password complexity validator to check if a string contains atleast one number, one uppercase letter, and one lowercase letter.

## Normalize strings in C#
Normalization: Converting a string to a common form (e.g. all lowercase) makes algorithms more efficient and less complex. We want the algorithms to be flexible and handle different contents.
Steps to Normalize: Use methods like ToLower, Trim, and Replace to convert the string to lowercase, remove whitespace, and eliminate unwanted characters.
Benefits: Normalizing data improves flexibility, efficiency, an readability of your algorithms.

Search for a letter
Algorithm 1: First search for a letter in lowercase, then search for the letter in uppercase
Algorithm 2: First convert the string to all lowercase, then search for the letter in lowercase form.

Another option is to limit your input to only a certain type, such as only a string with all lowercase letters with validation to make sure only strings are inputed.

## Parse and search strings in C#
String Search Methods: Using built-in Contains method to check if a substring exist within a string, noting that is is case-sensitive and not optimized for efficiency.
Iteration Techniques: Using foreach and for loops to iterate through a string with the for loop providing access to both the character and its index.
Optimizing Searches: The video demonstrates how to optimize searches by iterating only over even indices when looking for characters at even positions thus reducing the time complexity.

Common Task: Searching for a piece of data within a string
Assumptions to be made: If you know nothing about the string, you have to check every character. If the string's characters are sorted, you can optimize your algorithm based on order.
Regardless of Assumptions: Will need to be able to parse a string's contents.

## Create algorithm-driven strings in C#
String Reversal Algorithm: Using StringBuilder for efficiency
Handling Base Cases: Handling cases where the input string is null or empty
Using Built-in Functions: Using built-in functions when they are available and efficient, rather than creating custom algorithms from scratch.

## Code Challenge: Reverse each word
Consider other cases, such as what if there is extra spaces in the ends or inbetween the words, what if there was punctuation. How would the algorithm handle that?
```csharp
// C# code​​​​​​‌‌​‌​‌​‌​‌​‌‌‌‌​​‌​‌‌‌‌​‌ below
using System;
using System.Linq;
using System.Text;
// Write your answer here, and then test your code.
// Your job is to implement the ReverseEachWord() method.

public class Answer
{

    // Change these Boolean values to control whether you see 
    // the expected result and/or hints.
   public static Boolean ShowExpectedResult = false;
   public static Boolean ShowHints = false;

   public static string Reverse(string word)
   {
        char[] characters = word.ToCharArray();
        Array.Reverse(characters);
        string reversedWord = new string(characters);
        return reversedWord;
   }
    // Return a new string with each word reversed
    public static string ReverseEachWord(string sentence)
    {
        if (String.IsNullOrEmpty(sentence)) {
            return sentence;
        }
        string[] words = sentence.Split(' '); // [sally,is,a,great,worker]

        for (int i = 0; i < words.Length; i++) {
            words[i] = Reverse(words[i]);
        }

        return string.Join(" ",words); //combine back into string
        }
    }


// Solution using helper function

public static string ReverseEachWord(string sentence) {
    string[] words = sentence.Split(' ');
    string[] reversedWords = words.Select(Reverse).ToArray(); //select every word in the words array, and apply the Reverse function, then convert back into an array
    string reversedSentence = string.Join(" ",reversedWords);
    return reversedSentence;
}
```

# Array Algorithms
## Linear search arrays in C#
Linear Search: A sequential search method where each item in the array is checked one by one to find the target item.
Return Types: The algorithm can return a Boolean(true/false) or the item itself, with options to use a sentinel value or null for not found cases.
Built-in Functions: The Array.Find and Array.FindAll methods can be used to search for items in an array based on specified conditions.

Searching through data structures is a common task in software development. 
Input: the dataset and the item to search for
Output: true/false or the item itself.

## Binary Search Arrays in C#
Binary Search: A divide and conquer algorithm where in each step it halves the number of elements it has to search through.
Consider 0,2,8,19,45,75
Looking for 45, we would start at index 3; 19. and since 19 is less than the target it would continue the search to the right half.
..., 23,45,79

Linear Search: No assumptions, O(n) time
Binary Search: sorted assumption, O(log(n)) time

## Aggregate and filter arrays in C#
Aggregation and filtering: Combining two or more datasets into a single dataset and filtering out data that does not meet specific requirements.
    1. Merge arrays and then remove invalid items.
    2. Check each element and only keep valid items.
    3. Sort each array and take only valid items.
Implementation: Using a foreach loop to iterate through arrays and add even numbers to an ArrayList, which is then converted to an int array.
Time Complexity: Different Algorithms have varying time complexities based on the input data, and assumptions about the data can impact the algorithm's implementation.

## Reverse an array in C#
Two methods to reverse an array:
    -Creating a new Array: Copy the contents of the input array into a new array in reverse order
    -In-Place Reversal: Modify the input array directly by swapping elements from the front and back.
Algorithm Efficiency:
    -New Array Method: Iterates through the entire array.
    -In-Place Method: Only iterates through half of the array, making it more efficient.
Handling Edge Cases: Considerations for arrays with odd numbers of elements and ensuring the middle element remains in place.

## Code Challenge: Rotate an Array
```csharp
// C# code​​​​​​‌‌​‌​‌​‌​‌‌​​​​​‌‌​​‌‌​​‌ below
using System;
using System.Linq;
// Write your answer here, and then test your code.
// Your job is to implement the RotateArray() method.

public class Answer
{

    // Change these Boolean values to control whether you see 
    // the expected result and/or hints.
   public static Boolean ShowExpectedResult = true;
   public static Boolean ShowHints = false;

    // Return a new array with the input array's contents rotated
    // to the left by one
    public static int[] RotateArray(int[] numbers)
    {
        int temp = numbers[0];

        for(int i = 0; i < numbers.Length - 1; i++) {
            numbers[i] = numbers[i+1];
        }
        numbers[numbers.Length-1] = temp;
        
        return numbers;
    }

    public static int[] RotateArrayRight(int[] numbers) {
        int temp = numbers[numbers.Length-1] //Saving the last element to prevent out of bound error

        for(int i=numbers.Length-1; i > 0; i--) {
            numbers[i] = numbers[i-1]; //shift elements to the right, starting from the second to last, down to the first
        }
    }
        numbers[0] =temp; //place the last element at the front
        return numbers;
}


```
Apply learning through leetcode
Arrays
    -Valid Parentheses (stack to validate matching pairs)
    <!-- -Valid Anagram (check if strings are anagrams) -->
    <!-- -Palindrome Check (is the string a palindrome?) — simple two-pointer method -->

Normalize Strings / Parse & Search
    -Implement strStr() (search substring in a string)
    -Roman to Integer (parse and convert)
    -Count and Say (generate a string by describing previous string)

Reversing Strings
    -Reverse String (in-place reverse)
    -Reverse Words in a String (reverse word order, or reverse each word)
    -Longest Palindromic Substring (expand from center)

Linear Search & Binary Search
    <!-- -Binary Search (classic on sorted arrays) -->
    -Search Insert Position (find insert point)
    -First Bad Version (binary search on a function)

Aggregating & Filtering Arrays
    -Remove Duplicates from Sorted Array (in-place filtering)
    -Move Zeroes (aggregate non-zero elements)
    -Intersection of Two Arrays II (filter with counts)

Reversing & Rotating Arrays
    -Rotate Array (rotate array k steps to the right)
    -Reverse Words in a String II (in-place reverse words in char array)


# Linked List Algorithms
## What is a Linked List?
Structure: A linked list is a linear data structure where elements, called nodes, are linked using pointers. Each node contains data and a pointer to the next node.
Flexibility: Unlike arrays, linked lists do not store elements in contiguous memory locations, allowing for dynamic resizing and efficient insertions/deletions.
Components: The first node is called the head, and the last node is the tail, which points to null, indicating the end of the list. 
Advantages: Linked lists are useful for operations that involve frequent data modifications, as they allow for efficient insertion and deletion of elements without the need for resizing or shifting elements.

head            tail
5 -> 8 -> 10 -> 13 -> null
5 -> 8 -> null <!--will unlink the back half of the dataset--> 

## Common Linked list operation in C#
Creating a Linked List: You can create a linkedlist in C# using the LinkedList<type> from the System.Collections.Generic namespace. This type is generic and can hold various data type including custom objects.
Adding and Removing Data: You can add data to the linked list using methods like RemoveFirst, RemoveLast, or Remove for specific items.
Built-in Operations: The linked list provides built-in methods such as Contains to c heck if an item exists in the list and Count to get the number of items in teh list.
Simplified Interface: The built-in LinkedList class abstracts the complexity of nodes and pointers, allow you to focus on the data rather than the underlying implementation

## Linked list Algorithms
Custom Linked List Creation: You can create your own linked list class in c# with a head attribute and a nested node class, each node having data and a reference to the next node.
Iterating through a linked list: Use a loop with a current variable to traverse the linked list, ensuring to check for null nodes to avoid exeptions.
Deleting the back Half of a Linked List: Implement an algorithm using two pointers(slow and fast) to find the middle of the list, then set the previous node's next reference to null to delete the back half.

Original: 5 -> 8 -> 10 -> 13 -> null
Modified: 5 -> 8 -> null

## Code Challenge: Sum contents of a linked list
```Csharp
/*
Sum Contents of a linked list.
*/
// C# code​​​​​​‌‌​‌​‌​‌‌​​‌​‌​‌​​​‌‌‌‌​‌ below
using System;
using System.Linq;
// Write your answer here, and then test your code.
// Your job is to implement the sum() method.

public class Answer
{

    // Change these Boolean values to control whether you see 
    // the expected result and/or hints.
   public static Boolean ShowExpectedResult = false;
   public static Boolean ShowHints = false;

   public class ListNode
   {
        public int val;
        public ListNode next;

        public ListNode(int val)
        {
            this.val = val;
            this.next = null;
        }

        public override string ToString()
        {
            return val.ToString();
        }
   }

    // Return the sum of the contents in the linked list
    public static int Sum(ListNode head)
    {
        int total = 0;
        ListNode current = head;
        while (current != null) {
            total += current.val;
            current = current.next;
        }
        return total;
    }
}
```

# Queue and Stack Algorithms
## What is a queue?
FIFO Policy: A queue follows the First In First Out (FIFO) principle, meaning the first element added is the first one to be removed.
Enqueuing and Dequeuing: Items are added to the back of the queue(enqueuing) and removed from the front (dequeuing). You cannot add or remove items from the middle.
Accessing Elements: You can only access the item at the front of the queue directly. To access items further back, you must dequeue the items in front of it.
    enqueue
    dequeue
    peek

## Standard queue operations in C#
Queue Creation: Use the queue constructor from the System.Collections.Generic namespace to create a queue that can hold elements of any specified type.
Enqueue and Dequeue: Use the Enqueue method to add elements to the queue and Dequeue method to remove the first element, following the First-In First-Out(FIFO) policy.
Peek and TryDequeue: The Peek method allows you to view the first element without removing it, while TryDeQueue attempts to dequeue an element and returns true if successful., helping to avoid exceptions when the queue is empty.

## Queue Algorithms: Generate binary numbers
Binary Number Generation: The algorithm takes an integer N as input and prints the first N binary numbers in numerical order.
Queue Utilization: A queue is used to efficiently generate and print binary numbers by leveraging the FIFO pattern.
Pattern Recognitiion: The algorithm prints a number, then appends 0 and 1 to it, enqueues these new numbers, and continues until N numbers are printed.

## What is a Stack?
Stack Structure: A stack is an ordered collection of items that follows a Last-in First Out(LIFO) policy, meaning the last item added is the first one removed. 
Operations: The primary operations are push(adding an item to the top) and pop(removing the top item)
Use Case: Stacks are useful for algorithms that need to keep track of state, such as the runtime stack that manages function calls and nested functions in a program.

## Stack Algorithms: Theroizing an algorithm
Next Greater Element: The video explaisn how to find the next greater element for each element in an array using a stack. If no greater element exists, the value is set to -1.
Stack Usage: The stack is used to keep track of elements as you iterate through the array, allowing efficient matching of elements with their next greater element.
Efficiency: This approach eensures that the array is only iterated once, resulting in a linear time complexity, making the algorithm efficient.

Challenge: Print the next greater element for every element in the array
//Note: The next greater element is the first larger element on the right side of the array.
/*
Summary: We iterate through the array, trying to find the next greater element for the item on top of the stack. 
The stack contains the items we've already seen in the array.
When we've reached the end of the array, each item that's still in the stack must have the next greater element of -1

Linear Time Complexity
*/


input: {5,6,3,50}

Output: 
    5 -> 6
    6 -> 50
    3 -> 50
    50 -> -1

input: {15,8,4,10}

Output: 
    15 -> -1
    8 -> 10
    4 -> 10
    10 -> -1

## Stack Algorithms: Implementing next greater element
Algorithm Implementation: The video demonstrates how to implement the next greater element algorithm in C# using a stack to keep track of elements.
Stack Operations: The algorithm involves pushing elements onto the stack, popping elements to find the next greater element, and using a while loop to handle multiple elements.
Efficiency: The stack helps efficiently manage and find the next greater element for each item in the array, ensuring a linear time complexity.

## Stack Algorithms: Matching Parentheses
Stack Usage: The stack data structure is used to keep track of opening parentheses When a closing Parenthesis is encountered, the stack is popped to check for a match.
Algorithm Efficiency: The algorithm ensures that each opening parenthesis, and it runs in linear time with constant space when using an integer track for a single type of symbol.
Simplified Implementation: For a single type of symbol (parentheses), the stack can be replaced with an integer tracker to make the algorithm more efficient and easier to read.

Challenge: Determine whether a given piece of text has matching parentheses
Matching:
    ((hello()))
    ()(hello())
    ((hello))
    (hello)
Not Matching
    (hello(
    )hello)
    )hello(
    hello((
    (hello
    ((hello
## Code Challenge: Evaluate reverse Polish notation
```Csharp
//Time Complexity: O(n)
//Space Complexity: O(n)

// C# code​​​​​​‌‌​‌​‌​‌‌​​‌‌​‌​​​‌‌‌​‌‌‌ below
using System;
using System.Linq;
using System.Collections.Generic;
// Write your answer here, and then test your code.
// Your job is to implement the EvaluateRPN() method.

public class Answer {

    // Change these Boolean values to control whether you see 
    // the expected result and/or hints.
   public  static Boolean ShowExpectedResult = false;
   public  static Boolean ShowHints = true;

    public static bool IsNumber(string token)
    {
        try
        {
            double.Parse(token);
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }

    public static bool IsOperator(string token)
    {
        return "+-*/".Contains(token);
    }

    public static double PerformOperation(string @operator, double operand1, double operand2)
    {
        switch (@operator)
        {
            case "+":
                return operand1 + operand2;
            case "-":
                return operand1 - operand2;
            case "*":
                return operand1 * operand2;
            case "/":
                if (operand2 == 0)
                {
                    throw new DivideByZeroException("Division by zero is not allowed.");
                }
                return operand1 / operand2;
            default:
                throw new ArgumentException("Invalid operator: " + @operator);
        }
    }

     // Return the result of the Reverse Polish notation expression
    public static double EvaluateRPN(string expression) { //evaluates a string of Reverse Polish Notation(RPN) and return a double result
        string[] tokens = expression.Split(' '); //splits the input string into an array of tokens(numbers and operators), based on spaces
        Stack <double> stack = new(); //initalizes a stack to store numbers during the evaluation, will hold operands until an operator is applied

        foreach(string token in tokens) { //loop through each token in the RPN expression
            if(IsNumber(token)) { //if the token is a number
                stack.Push(double.Parse(token)); //parse it to a double and push it onto the stack, these are the future operands
            }
            else if(IsOperator(token)) { //if its an operator pop the last two numbers from the stack ex: 5 3 -
                double operand2 = stack.Pop(); //pops the second operand from the stack 3
                double operand1 = stack.Pop(); //pops the first operand from the stack 5
                double result = PerformOperation(token,operand1,operand2); //peforms the operation between the two operands.
                stack.Push(result); //push the result back on the stack so it can be used in the future
            }
        }
            return stack.Pop(); //Once all the tokens are processed, the stack should have one number left - the final result.
    }
}
```

# Algorithms for Hash
## Hash-Based structures in C#
HashSet: A collection of unique items where the order of items is not relevent. It is useful for keeping track of a unique list of items, such as validating vendor codes quickly.
    collection of unordered collection of unique items 
    ex: Unique Vendor Codes:
        "TRJ or KPE"
Dictionary: Stores key-value pairs and is useful for looking up information using an identifier like an employee ID. It adds type safety and maintains the order of stored values.
Generic Collection, Type safetey, invalid key results in error, thread safe only for public static members (usually recommended over hashtable because of type safety)
    Example: Store Each Employee value by id (key)
        Gary: 0123
        Friend: 4567
        friend2: 8900
HashTable: Similar to Dictionary but does not require specifying the type of key or value. It returns null for non-existent keys and is thread-safe, but does not maintain th order of stored values.
NonGeneric, no type safety, invalid key results in null, thread safe

## Dictionary and HashSet operations in C#
Dictionary: Used to store key-value pairs, making it efficient to retreive data using a unique key. The TryGetValue method helps check if a key exists and retreive its value.
HashSet: Ideal for storing unique items where order doesn't matter. It allows quick checks to see if an item is part of the set using the Contains Method. 
Efficiency: Both structures optimize data retreival by assuming uniqueness--keys in dictionarys and values in HashSet--speeding up algorithm performance.

## Leverage the HashSet type in C# algorithms
Membership Check: The HashSet is used to determine if elements from one array are present in another array, focusing on membership without concern for order.
Efficiency: By leveraging the uniqueness of items in a HashSet, the algorithm can perform membership checks in constant time, making it efficient
Implementation: The video demonstrates creating an algorithm that uses a HashSet to find elements in the first array that are not in the second array, iterating through both arrays and using the HashSet.Contains method.

Challenge: Find items present in the first array, but not the second array.

{3,2,8,4,5}
{5,7,3,0,2}
This is a question of membership.

## Use the Dictionary Type in C# algorithms
Key-Value Pairs: The dictionary type in C# uses key-value pairs to store data, where each key is unique, and the value represents the data associated with that key. 
Element Frequency: The video demonstrates using a Dictionary to count the frequency of elements in an unsorted array, making it easy to track and display how many times each element appears.
Efficient Data Management: By leveraging the Dictionary type, you can efficiently manage and retreive data based on unique keys, optimizing your algorithm's performance.

Challenge:
Display the count of each element in an unsorted array
<key = element, value= count of element>{5,7,3,0,2}


## Code Challenge: Detect a cyclic linkedlist
```Csharp
// C# code​​​​​​‌‌​‌​‌​‌‌​‌​​​‌‌​‌​‌‌​‌‌‌ below

//Time Complexity: O(n) because I have to potentially traverse every node
//Space Complexity O(1) because it only uses constant memory


using System;
using System.Linq;
using System.Collections.Generic;
// Write your answer here, and then test your code.
// Your job is to implement the hasCycle() method.

public class Answer {

    // Change these Boolean values to control whether you see 
    // the expected result and/or hints.
   public static Boolean ShowExpectedResult = false;
   public static Boolean ShowHints = false;
   
   public class ListNode
   {
       public int Val;
       public ListNode Next;

        public ListNode(int val) {
            this.Val = val;
            this.Next = null;
        }
    }

    // Return true or false depending on if there's a 
    // cycle in the Linked List 
    public static bool HasCycle(ListNode head)
    {
        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.Next != null) {
            slow = slow.Next;
            fast = fast.Next.Next;

            if (slow == fast) {
                return true;
            }
        }
        return false;
    }

}

//Alternate way to solve using HashSet with Time Complexity: Constant O(n)  and Space Complexity: Constant O(n)

public static bool HasCycleHashSet(ListNode head) 
{
    HashSet<ListNode> nodes = new ();
    ListNode current = head;
    while(current != null) {
        if(nodes.Contains(current)) {
            return true;
        } else {
            nodes.Add(current);
        } 
        current = current.Next; 
    }
    return false;
}
```

# Tree Algorithms
## What is a tree?
A tree: A nonlinear data structure consisting of nodes, where each node can have multiple child nodes, forming different levels and paths. A collection of nodes connected by links.
The root node: is the starting point of the tree, and it has no parent. Nodes connected to the root are called child nodes.
A binary tree: is a specialized type of tree where each node has a maximum of two child nodes, which help in organizing data efficiently.
A binary search tree: Adds an order constraint: the left child node must have a value less than its parent and the right child node must have a value greater than its parent, making data retrieval more efficient.
    Best-case search time is O(log(n))
    Worse-case search time is O(n)

## Create a binary search tree in C#
Binary Search Tree Structure: A binary search tree(BST) uses nodes with left and right references to organize data efficiently. Each node can have at most two child nodes.
Node Class: The node class in C# for a BST includes attributes for left and right nodes and data, with get and set accessors.
Insertion Algorithm: The video explains how to create an algorithm to insert data into a BST. The algorithm uses recursion to find the correct position for the new node based on its value relative to the root node.
Recursion: Recursion is used to insert nodes, ensuring the BST properties are maintained. The algorithm checks if the root is null, and if not, it inserts the value on the left or right side based on its comparison with the root's value.

## What are tree traversals?
InOrder Traversal: Visits the left subtree first, then the root node, and finally the right subtree. This traversal is useful for binary search trees as it visits nodes in a sorted order.
    inorder: explores data sequentially

Pre-order Traversal: Visits the root node first, followed by the left subtree, and then the right subtree. This method is useful when you need to explore the root before inspecting the leaves.
    Preorder: explores roots before leaves(nodes with no children)

Post-order Traversal: Visits the left subtree first, then the first subtree, and finally the root node. This traversal is beneficial when you need to explore theh leaves before the root.
    Postorder: explores leaves before roots

## Using recursion to implement tree traversals in C#
Tree traversal algorithms: The video explains three types of tree traversal algorithms: pre-order, in-order, and post-order, each vising nodes in a specific order.
Recursion: Recursion is used to simplify the traversal process by repeatedly applying the same operation to subtrees.
Implementation: The video demonstrates how to implement these traversals in C#, showing how to write and debug the code for each traversal type.

## Code Challenge: Find height of binary tree
Base Case: If the root of the tree is null, the height is zero.
Recursive Calculation: If the root is not null, calculate the height of the left and right subtrees recursively.
Total Height: The height of the tree is 1(for the root) plus the maximum height of the left and right subtrees.
Time Complexity: The function takes O(n) time because it visits every node in teh tree to calculate the height.

```Csharp
//Code:
// C# code​​​​​​‌‌​‌​‌​‌‌​‌​‌​‌​​​​‌​​​​‌ below
using System;
using System.Linq;
// Write your answer here, and then test your code.
// Your job is to implement the FindHeight() method.

public class Answer {

    // Change these Boolean values to control whether you see 
    // the expected result and/or hints.
   public static Boolean ShowExpectedResult = false;
   public static Boolean ShowHints = false;

   public class TreeNode
   {
        public int Val { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(int val)
        {
            Val = val;
        }
    }

    // Return the maximum depth of the binary tree
    public static int FindHeight(TreeNode root)
    {
        // write code here
        if(root == null) {
            return 0;
        }

        int leftHeight = FindHeight(root.Left);
        int rightHeight = FindHeight(root.Right);

        // int height = 1 + Math.Max(leftHeight,rightHeight);
        return leftHeight > rightHeight ? leftHeight + 1 : rightHeight +1;
        // return height;
    }

}
```