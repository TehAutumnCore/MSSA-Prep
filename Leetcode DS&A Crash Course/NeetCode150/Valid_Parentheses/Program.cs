//Valid Parantheses
/*
Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

An input string is valid if:

Open brackets must be closed by the same type of brackets.
Open brackets must be closed in the correct order.
Every close bracket has a corresponding open bracket of the same type.
 

Example 1:
Input: s = "()"
Output: true

Example 2:
Input: s = "()[]{}"
Output: true

Example 3:
Input: s = "(]"
Output: false

Example 4:
Input: s = "([])"
Output: true

 

Constraints:

1 <= s.length <= 104
s consists of parentheses only '()[]{}'.
*/

//Time Complexity:
//Space Complexity:
//Solution:

// using System;
// using System.Collections.Generic;

public class Solution {
    public bool IsValid(string s) { // {[({})]}  ){}[]        LIFO- Last In(push) First-Out(pop)

        if (string.IsNullOrEmpty(s)) return true;//checks if the string is empty or null before using the stack
        if (s.Length % 2 == 1) return false;

        Stack<char> stack = new(); //initalize the stack
        
        foreach (char c in s) { //loop through each character in the string
            if(c == '(' || c == '{' || c == '[') { //check if the current character is an opening bracket
                stack.Push(c); //push that character to the stack
            }
            else {
                if(stack.Count == 0) return false; //if the stack is empty after the push 
                
                char top = stack.Pop(); //pop the top of the stack
                if (c == ')' && top != '(') return false; // check if the outer most bracket matches the corresponding top
                if (c == '}' && top != '{') return false;
                if (c == ']' && top != '[') return false;
            }
        }
        return stack.Count == 0; //if stack.Count is 0, its empty meaning all pairs found, else didnt have a pair
    }
}