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

//Time complexity: O(n) because we visit every node once.
 //Space Complexity: O(h) with h being the height of the treet
public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        return MaxDepthHelper(root);
    }

    private int MaxDepthHelper(TreeNode root)
    {
        if (root == null) return 0;

        int leftHeight = MaxDepthHelper(root.left);
        int rightHeight = MaxDepthHelper(root.right);

        int maximumDepth = leftHeight > rightHeight ? leftHeight + 1 : rightHeight + 1;

        return maximumDepth;
    }
}