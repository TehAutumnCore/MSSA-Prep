/*
1046. Last Stone Weight
Solved
Easy
Topics
Companies
Hint
You are given an array of integers stones where stones[i] is the weight of the ith stone.

We are playing a game with the stones. On each turn, we choose the heaviest two stones and smash them together. Suppose the heaviest two stones have weights x and y with x <= y. The result of this smash is:
If x == y, both stones are destroyed, and
If x != y, the stone of weight x is destroyed, and the stone of weight y has new weight y - x.
At the end of the game, there is at most one stone left.
Return the weight of the last remaining stone. If there are no stones left, return 0.

 

Example 1:

Input: stones = [2,7,4,1,8,1]
Output: 1
Explanation: 
We combine 7 and 8 to get 1 so the array converts to [2,4,1,1,1] then,
we combine 2 and 4 to get 2 so the array converts to [2,1,1,1] then,
we combine 2 and 1 to get 1 so the array converts to [1,1,1] then,
we combine 1 and 1 to get 0 so the array converts to [1] then that's the value of the last stone.
Example 2:

Input: stones = [1]
Output: 1
 

Constraints:
1 <= stones.length <= 30
1 <= stones[i] <= 1000
*/


// Time Complexity: O(n log n)
// Space Complexity: O()
// Solution: 

public class Solution {
    public int LastStoneWeight(int[] stones) {

        PriorityQueue<int, int> priorityQueue = new PriorityQueue<int,int>(); //creates a min-priority queue(min heap)
        foreach (int stone in stones){ 
            priorityQueue.Enqueue(stone, -stone); //Enqueues each element as negative ->-8,-7,-4,-2,-1,-1 -> abs()
        }
        while(priorityQueue.Count > 1) { //while there is more than 1 stone left
            int rock1 = priorityQueue.Dequeue(); //smallest number
            int rock2 = priorityQueue.Dequeue(); //2nd smallest number

            if (rock1 != rock2) { //if the values arent equal- SMASH!
                int leftOver = Math.Abs(rock1-rock2); //using absolute to mimic a maxheap, add add 2 positive numbers
                priorityQueue.Enqueue(leftOver, -leftOver); //enqueue the leftover back into the heap as negative
            }
        }
        return priorityQueue.Count == 1 ? priorityQueue.Dequeue() : 0;//if count==1 return last stone-weight, else return 0
    }
}