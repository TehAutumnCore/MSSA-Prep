//Evaluate Reverse Polish Notation
//Time Complexity: O()
//Space Complexity:O()

// using System;
// using System.Collections.Generic;

public class Solution {
    public int EvalRPN(string[] tokens) {
        if(tokens == null) return 0; //checks if string is equal to null
        if(tokens.Length == 0) return 0; //checks if empty string
        
        Stack<int> stack = new(); //initialize stack
        
        
        foreach(string token in tokens) { //foreach character in string
            if (int.TryParse(token,out int number)) {//tries to convert the string S into an integer
                stack.Push(number); //if conversion succeeds, stores converted number in number variable and push to stack
            } else { //if token isn't an integer then its an operator
                int operand2 = stack.Pop(); //pop and assign element to operand2
                int operand1 = stack.Pop(); //pop and assign element to operand1
                switch(token) { //checks the token to see which operator it is
                    case "*":
                        stack.Push(operand1 * operand2); //multiplication
                        break;
                    case "+":
                        stack.Push(operand1 + operand2); //addition
                        break;
                    case "-":
                        stack.Push(operand1 - operand2); //subtraction
                        break;
                    case "/":
                        stack.Push(operand1 / operand2); //division
                        break;
                    }
                }
            }
            return stack.Pop(); //returns the only number in the stack
        }
    }