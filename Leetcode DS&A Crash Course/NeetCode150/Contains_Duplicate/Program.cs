// Contains Duplicate

//Time Complexity: O(n)
//Space Complexity: O(n)

using System.Collections.Generic;

public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int,int> duplicate = new(); //create a dictionary to store seen values to compare to.

        for(int i=0; i < nums.Length; i++) { //Iterate through the input array
            if (!duplicate.ContainsKey(nums[i])) { //If the number hasnt been seen, add it to the dictionary
                duplicate[nums[i]] = 1; //mark the number as seen
            } else { //if (duplicate.ContainsKey(nums[i])) {  //if the value does exist, return true
                return true; //duplicate found
            }
        }
        return false; //no duplicate found
    }
}

//Another way to solve:
//HashSet only stores key -> When you only care if something exists(such as duplicates)
//Dictionary stores key, value -> when you need to track values such as counts or mappings

// using System.Collections.Generic;
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> seen = new();

        foreach (int num in nums) {
            if(seen.Contains(num)) {
                return true;
            }
            seen.Add(num)
        }
        return false;
    }
}