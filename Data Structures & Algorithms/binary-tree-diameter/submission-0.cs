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
    private int diameter = 0;

    private int Height(TreeNode root)
    {
    if (root is null)
        return 0;

        int left = Height(root.left);
        int right = Height(root.right);

        diameter = Math.Max(left + right, diameter);

        return 1 + Math.Max(left, right);
    }
    public int DiameterOfBinaryTree(TreeNode root) {
        Height(root);
        return diameter;
    }


}
