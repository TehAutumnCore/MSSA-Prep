//Valid Palidrome
/*
A phrase is a palindrome if, after converting all uppercase letters into lowercase letters and removing all non-alphanumeric characters, it reads the same forward and backward. Alphanumeric characters include letters and numbers.

Given a string s, return true if it is a palindrome, or false otherwise.

 

Example 1:

Input: s = "A man, a plan, a canal: Panama"
Output: true
Explanation: "amanaplanacanalpanama" is a palindrome.
Example 2:

Input: s = "race a car"
Output: false
Explanation: "raceacar" is not a palindrome.
Example 3:

Input: s = " "
Output: true
Explanation: s is an empty string "" after removing non-alphanumeric characters.
Since an empty string reads the same forward and backward, it is a palindrome.
*/

// Time Complexity: O(n)
// Space Complexity: O(1)
public class Solution {
    public bool IsPalindrome(string s) {
        if (string.IsNullOrWhiteSpace(s)) { //if the string is either null or a whitespace return true
            return true;
        }

        s = s.ToLower(); //normalizes the string by lowercasing the string

        int left = 0; //defining the left pointer
        int right = s.Length-1;//defining the right pointer

        while(left<right) { //while the left and right pointer are not equal
            while(left < right && !char.IsLetterOrDigit(s[left])) { //while the pointers are not equal and the right pointer is a letter or number(skipping non letters/numbers)
                left++; //move the left pointer right one
                
            }
            while(left<right && !char.IsLetterOrDigit(s[right])) { //while the left and right pointer are not equal and the right pointer is a letter or number(skipping non letters/numbers)
                right--;//move the right pointer left one
                
            }
            if(s[left] != s[right]) { //if at any point, the left and right pointer do not equal each other return false
                    return false; //
                } else{ //if the left and right pointer equal one another, move both pointers over one
                    left++; 
                    right--;
                }
        }
        return true; //is a palindrome
    }
}