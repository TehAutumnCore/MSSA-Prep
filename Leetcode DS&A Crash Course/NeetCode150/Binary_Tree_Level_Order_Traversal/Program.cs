//102. Binary Tree Level Order Traversal
/*
Medium
Topics
Companies
Hint
Given the root of a binary tree, return the level order traversal of its nodes' values. (i.e., from left to right, level by level).

Example 1:
Input: root = [3,9,20,null,null,15,7]
Output: [[3],[9,20],[15,7]]

Example 2:
Input: root = [1]
Output: [[1]]

Example 3:
Input: root = []
Output: []
 

Constraints:

The number of nodes in the tree is in the range [0, 2000].
*/
// Time Complexity: O(n)
// Space Complexity: O(n)
// Solution:


/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<IList<int>> LevelOrder(TreeNode root) { //IList is a list of lists
        //base case
        if (root == null) return new List<IList<int>>(); //if tree is empty(root is null) return empty list
        
        //creating a queue
        Queue<TreeNode> queue = new(); //initalizes queue to hold nodes for process
        queue.Enqueue(root); //enques the root note(starting point for BFS)
        
        //creates an answer list
        IList<IList<int>> result = new List<IList<int>>(); //creates a list of lists called results

        while(queue.Count != 0){ //as long as the node queue isnt empty
            List<int> levelList = new(); //for each iteration create a new list level to hold values
            int currentLevelSize = queue.Count; //captures how many nodes at current level
            for(int i = 0; i < currentLevelSize; i++) { //run exactly the current level's nodes count
                TreeNode node = queue.Dequeue(); //take the next node from queue
                levelList.Add(node.val); //add its value to the current level's list

                if (node.left != null) queue.Enqueue(node.left); //if the current node has a left child, enqueue it
                if (node.right != null) queue.Enqueue(node.right); //if the current node has a right child, enqueue it
            }
            result.Add(levelList); //add all the collected values to the final result
        }
        return result; //return the result list of lists.
    }
}


/*
Summary of the flow:
Start with the root in the queue.

While the queue isn’t empty:
    Take a snapshot of how many nodes are in the queue (currentLevelSize) — those are all nodes at the current level.
    Dequeue exactly that many nodes, collect their values into a level list.
    Enqueue their children (which belong to the next level).
    Add the completed level list to result.
When finished, return the list of all levels.
*/
