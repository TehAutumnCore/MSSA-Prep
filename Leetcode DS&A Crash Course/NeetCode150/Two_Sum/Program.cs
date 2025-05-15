/*
1. Two Sum
Solved
Easy
Topics
Companies
Hint
Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
You may assume that each input would have exactly one solution, and you may not use the same element twice.
You can return the answer in any order.
 
Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].
Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]
Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
 

Constraints:
2 <= nums.length <= 104
-109 <= nums[i] <= 109
-109 <= target <= 109
Only one valid answer exists.
 

Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?
*/

//Two Sum Solution: 
//Time Complexity: O(n) - passes through the nums array once.
//Space Complexity: O(n) Dictionary stores up to n entries (space complexity is based on worse scenario)
using System.Collections.Generic;

public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //base cases -> checks if nums is null or is empty
        if (nums == null || nums.Length == 0) {
            return nums;
        }
        
        //Key:Value -> Value:Index
        //creates an empty Dictionary to store the answer
        Dictionary<int,int> answer = new();
        
        for (int i=0; i < nums.Length; i++) { // for loop
            int diff = target - nums[i]; //the difference is the target - the current number in the iteration
            if (answer.ContainsKey(diff)) { //checks if the difference is already inside of the Dictionary
                return new int[] {answer[diff], i}; //if so it returns a new int[] with the diff value and the current number in the iteration
            }
            answer[nums[i]] = i; //stores the current number and index to compare
        }
        return new int[0]; //if no valid pair is found returns empty array.
    }
}