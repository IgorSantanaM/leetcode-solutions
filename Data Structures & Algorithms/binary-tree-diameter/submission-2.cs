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
    public int diameter = 0;
    public int Height(TreeNode root) {
        if(root is null)
            return 0;

        var left = Height(root.left);
        var right = Height(root.right);

        diameter = Math.Max(left + right, diameter);

        return 1 + Math.Max(left, right);
    }
    public int DiameterOfBinaryTree(TreeNode root) {
        Height(root);
        return diameter;
    }
}
