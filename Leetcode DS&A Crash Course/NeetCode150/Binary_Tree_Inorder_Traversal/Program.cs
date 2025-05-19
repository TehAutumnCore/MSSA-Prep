//Binary_Tree_Inorder_Traversal

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
    public IList<int> InorderTraversal(TreeNode root) {
        List <int> result = new();
        InOrderTraversalHelper(root,result);
        return result;
    }
    
    private void InOrderTraversalHelper(TreeNode root, List<int> result) {
        if(root == null) return;

        InOrderTraversalHelper(root.left, result);
        result.Add(root.val);
        InOrderTraversalHelper(root.right, result);
    }
}