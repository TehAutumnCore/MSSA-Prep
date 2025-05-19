//Invert Binary Tree
/*226. Invert Binary Tree
Easy
Topics
Companies
Given the root of a binary tree, invert the tree, and return its root.

 

Example 1:


Input: root = [4,2,7,1,3,6,9]
Output: [4,7,2,9,6,3,1]
Example 2:


Input: root = [2,1,3]
Output: [2,3,1]
Example 3:

Input: root = []
Output: []
 

Constraints:

The number of nodes in the tree is in the range [0, 100].
-100 <= Node.val <= 100
*/
//Time Complexity: O(n) because we visit every node once
// Space Complexity: O(h) h is the height of the tree
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
public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        return InvertTreeHelper(root);
    }
    private TreeNode InvertTreeHelper(TreeNode root)
    {
        if (root == null) return null;

        TreeNode temp = root.left;
        root.left = InvertTreeHelper(root.right);
        root.right = InvertTreeHelper(temp);

        return root;
    }
}


/*
BFS(using a queue)
Time Complexity: O(n)
Space Complexity: O(n)
*/
using System;
using System.Collections.Generic;

public class Solution {
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null) return null;

        Queue<TreeNode> queue = new();
        stack.Enqueue(root);

        while (queue.Count > 0)
        {
            TreeNode node = queue.Dequeue();

            TreeNode temp = node.left;
            node.left = node.right;
            node.right = temp;

            if (node.left != null) queue.Enqueue(node.left);
            if (node.right != null) queue.Enqueue(node.right);
        }
        return root;
    }
}


/* 
//DFS (using a stack)
Time Complexity: O(n)
Space Complexity: O(h), could be O(n in worst case)
using System;
using System.Collections.Generic;
public class Solution
{
    public TreeNode InvertTree(TreeNode root)
    {
        if (root == null) return null;

        Stack<TreeNode> stack = new();
        stack.Push(root);

        while (stack.Count > 0)
        {
            TreeNode node = stack.Pop();

            TreeNode temp = node.left;
            node.left = node.right;
            node.right = temp;

            if (node.right != null) stack.Push(node.right);
            if (node.left != null) stack.Push(node.left);
        }
        return root;
    }
}