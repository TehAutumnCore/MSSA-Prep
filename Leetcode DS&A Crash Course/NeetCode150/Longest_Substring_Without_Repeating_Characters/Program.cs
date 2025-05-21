/*
Longest Substring Without Repeating Characters

Solution
Given a string s, find the length of the longest substring without duplicate characters.

 

Example 1:

Input: s = "abcabcbb"
Output: 3
Explanation: The answer is "abc", with the length of 3.
Example 2:

Input: s = "bbbbb"
Output: 1
Explanation: The answer is "b", with the length of 1.
Example 3:

Input: s = "pwwkew"
Output: 3
Explanation: The answer is "wke", with the length of 3.
Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
 

Constraints:
0 <= s.length <= 5 * 104
s consists of English letters, digits, symbols and spaces.
*/
// Time Complexity: O(n^2)
// Space Complexity: O(n)

// Solution:
//Sliding Window Technique
public class Solution {
    public int LengthOfLongestSubstring(string s) {
        
        HashSet<char> hashset = new(); //defines hashset to track the characters in the current window.
        int left = 0; //creates left pointer
        int right = 0; //creates right pointer
        int maxLength = 0; //will keep track of any valid window without no repeating characters seen so far
        
        while (right < s.Length) { //use right pointer to explore new chars
            if (hashset.Contains(s[right])) { //if the character at index right exist in the hashset, theres a duplicate
                hashset.Remove(s[left]); //if so remove it
                    left++;//move the pointer
            } else {//if the character is not in the hashset; no duplicate in hashset
                hashset.Add(s[right]);//theres no duplicate so add character at right pointer to hashset
                right++; //move the right pointer over
                maxLength = Math.Max(maxLength,right-left); //check if the current window six is the largest we've seen so far, if so reassign the value
                }
            }
        return maxLength; //maxLength holds the length of the longest subsring with no repeating characters
    }
}

//windows
//track window length
//check if window has the value at the right pointer
    //if so remove the left pointer value
    //move left pointer
//if no duplicate
    //add the value at the right pointer
    //move right pointer over
    //update max length value
//return max length value

/*
public class Solution {
    public int LengthOfLongestSubstring2(string s) {
        int left = 0;
        int right = 0;
        int maxLength = 0;

        HashSet<char> result = new HashSet<int>();

        while(right < s.Length) {
            if(result.Contains(s[right])) {
                result.Remove(s[left]);
                left++;
            } else {
                result.Add(s[right]);
                right++;
                maxLength = Math.Max(maxLength, right-left);
            }
        }
        return maxLength;
    }
}


Time Complexity: O(n)
Space Complexity:  O(min(n,m))
*/
public class Solution {
    public int LengthOfLongestSubstring3(string s) {
    while(right < s.Length) { 
        while(HashSet.Contains(s[right])) { //while the right pointer char is a duplicate
            hashSet.Remove(s[left]); //remove the left pointer char
            left++; //move the left pointer
        }
        hashSet.Add(s[right]); // while not a duplicate
        maxLength = Math.Max(maxLength, right-left);//compare the window size too previous window
        right++;//move the pointer
        }
        return maxLength;//return the largest window size recorded
    }
}