﻿//Same Tree
/*
100. Same Tree
Solved
Easy
Topics
Companies
Given the roots of two binary trees p and q, write a function to check if they are the same or not.

Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.



Example 1:

Input: p = [1,2,3], q = [1,2,3]
Output: true
Example 2:

Input: p = [1,2], q = [1,null,2]
Output: false
Example 3:

Input: p = [1,2,1], q = [1,1,2]
Output: false
*/
//Solution:
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
 
 //Time Complexity: O(n)
 //Space Complexity: O(h)
public class Solution
{
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        return IsSameTreeHelper(p, q);
    }
    private bool IsSameTreeHelper(TreeNode p, TreeNode q)
    {
        if (p == null && q == null) return true;
        if (p == null || q == null) return false;
        if (p.val != q.val) return false;

        bool leftHeight = IsSameTreeHelper(p.left, q.left);
        bool rightHeight = IsSameTreeHelper(p.right, q.right);

        return leftHeight && rightHeight;
    }
}