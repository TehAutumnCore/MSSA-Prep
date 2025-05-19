﻿//Binary_Tree_Preorder_Traversal

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
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> result = new();
        PreorderTraversalHelper(root,result);
        return result;
    }

    private void PreorderTraversalHelper(TreeNode root, List<int> result) {
        if(root == null)  return;

        result.Add(root.val);
        PreorderTraversalHelper(root.left, result);
        PreorderTraversalHelper(root.right, result);
    }
}