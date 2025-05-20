// Lowest Common Ancestor of a Binary Tree
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
 //Time Complexity: O(n)  n = number of nodes
 //Space Complexity: O(n) n = height of the tree
public class Solution {
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        return LowestCommonAncestorHelper(root, p, q);
    }

    private TreeNode LowestCommonAncestorHelper(TreeNode root, TreeNode p, TreeNode q) {
        //base cases
        if (root == null) return null; //no tree to search, gone past a leaf
        if (root == p || root == q) return root; //base case: found p or q
        //recursive cases
        TreeNode left = LowestCommonAncestorHelper(root.left, p, q); //search left subtree for p or q
        TreeNode right = LowestCommonAncestorHelper(root.right, p, q); //search right subtree for p or q
        //recursive case
        if (left != null && right != null) return root; //if p and q are found in different subtrees, return root
        // return left != null ? left : right; //return the non null subtree
        return left ?? right; //return the subtree that found p or q(or null if neither is found)
    }
}