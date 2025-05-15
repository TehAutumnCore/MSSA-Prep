//Valid Anagram
/*
Given two strings s and t, return true if t is an anagram of s, and false otherwise.

Example 1:
Input: s = "anagram", t = "nagaram"
Output: true

Example 2:
Input: s = "rat", t = "car"
Output: false



Constraints:

1 <= s.length, t.length <= 5 * 104
s and t consist of lowercase English letters.
 
Follow up: What if the inputs contain Unicode characters? How would you adapt your solution to such a case?
*/

//Time: O(n)
//Space Complexity: O(n)

public class Solution {
    public bool IsAnagram(string s, string t) {
        //will store the count of every character that appears and then compare those counts
        //char : count

        if (s.Length != t.Length || string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) { //checks if both strings match in length, and neither is null or empty
            return false;
        }
        
        Dictionary<char,int> counts = new();
        
        //first iteration will check if 
        foreach(char c in s) { //for every character in the string
            if(counts.ContainsKey(c)) { //check if the dictionary contains that character
                counts[c]++; //if that character exist increment
            } else {
                counts[c] = 1; //if that character doesn't exist, give it an intial value of 0
            }
        }
        foreach(char c in t) { //for every character in the string
            if(!counts.ContainsKey(c)) { //if the dictionary does NOT contain the character 
                return false; //return false
            }
            counts[c]--; // decrement with each iteration
            if (counts[c] < 0) { //if the count goes below 0 
                return false; //return false
            }
        }
        return true; //return true if anagram
    }
}

/*
        //bonus check but optional
        foreach (char c in t) {
            if(!counts.ContainsKey(c) || counts[c]=0) {
                return false;
            }
            counts--;
        }
        return true;
            }
        }
*/