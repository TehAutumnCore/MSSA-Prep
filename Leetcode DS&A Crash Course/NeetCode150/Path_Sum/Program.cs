﻿//Path Sum
/*
112. Path Sum
Easy
Topics
Companies
Given the root of a binary tree and an integer targetSum, return true if the tree has a root-to-leaf path such that adding up all the values along the path equals targetSum.

A leaf is a node with no children.

Example 1:

Input: root = [5,4,8,11,null,13,4,7,2,null,null,null,1], targetSum = 22
Output: true
Explanation: The root-to-leaf path with the target sum is shown.
Example 2:

Input: root = [1,2,3], targetSum = 5
Output: false
Explanation: There are two root-to-leaf paths in the tree:
(1 --> 2): The sum is 3.
(1 --> 3): The sum is 4.
There is no root-to-leaf path with sum = 5.
Example 3:

Input: root = [], targetSum = 0
Output: false
Explanation: Since the tree is empty, there are no root-to-leaf paths.
 
Constraints:
The number of nodes in the tree is in the range [0, 5000].
-1000 <= Node.val <= 1000
-1000 <= targetSum <= 1000

*/

//Solution
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

//Time Complexity: O(N) for visiting each node once
 //Space Complexity: O(H), H is the height of the tree, worse case is H=N, so O(N), for balanced trees, H = log N
public class Solution
{
    public bool HasPathSum(TreeNode root, int targetSum)
    {
        return HasPathSumHelper(root, targetSum); //return result from helper function
    }
    private bool HasPathSumHelper(TreeNode root, int targetSum)
    {
        if (root == null) return false; //Base Case: null: node means no more path

        bool leaf = (root.left == null && root.right == null); //defining leaf:no children
        if (leaf) return targetSum == root.val; //if root is a leaf, return whether or not the target sum == root.val

        targetSum -= root.val; //subtract current node value from remaining target sum
        return HasPathSumHelper(root.left, targetSum) || HasPathSumHelper(root.right, targetSum);
        //recurse left and right and return true if eitehr subtree has valid path.
    }
}