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
    int diameter; //private int diameter = 0
    public int DiameterOfBinaryTree(TreeNode root) {
        DiameterOfBinaryTreeHelper(root);
        return diameter;
    }

    private int DiameterOfBinaryTreeHelper(TreeNode root) {
        if(root==null) return 0;

        int leftHeight = DiameterOfBinaryTreeHelper(root.left);
        int rightHeight = DiameterOfBinaryTreeHelper(root.right);

        int height = (leftHeight > rightHeight) ? leftHeight+1 : rightHeight+1;
        
        diameter = diameter > leftHeight + rightHeight ? diameter : leftHeight + rightHeight;

        return height;
    }
}