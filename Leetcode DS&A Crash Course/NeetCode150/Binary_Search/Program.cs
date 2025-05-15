//Binary Search
/*
Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. If target exists, then return its index. Otherwise, return -1.

You must write an algorithm with O(log n) runtime complexity.

 

Example 1:

Input: nums = [-1,0,3,5,9,12], target = 9
Output: 4
Explanation: 9 exists in nums and its index is 4
Example 2:

Input: nums = [-1,0,3,5,9,12], target = 2
Output: -1
Explanation: 2 does not exist in nums so return -1
*/

//Time Complexity: O(log n) -> this is because the search space halves with each iteration
//Space Complexity: O(1)

using System.Collections.Generic;

public class Solution {
    public int Search(int[] nums, int target) {

        int left = 0; //creates a left point at starting index
        int right = nums.Length-1; //creates a right pointer at the last index
        
        while (left <= right) { // run this loop while left <= right this is because with left < right, you dont inclusively check the values at the left or right index
            int mid = left + (right-left) / 2; //since right is always larger than left, adding left will prevent overflow
            if (target > nums[mid]) { // if the target is more than the value at the mid index
                left = mid + 1; //reassign the left pointer to the mid index +1 to move the pointer to the right of the original mid placement
            }
            else if (target < nums[mid]) { //if the target is less than the value at the mid index
                right = mid - 1; //will reassign the right index to mid -1, the value to the left of the original mid placement
            }
            if(target==nums[mid]){ //if the target is confirmed to be at the mid index of nums
                return mid; //return the value of the index
            }
        }
        return -1; //return false
    }
}