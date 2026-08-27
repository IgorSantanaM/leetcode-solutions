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
    public bool IsValidBST(TreeNode root) {
        return Valid(root, int.MaxValue, int.MinValue);
    }

    public bool Valid(TreeNode root, int max, int min)
    {
        if(root is null)
            return true;
        if(!(min < root.val && root.val < max))
            return false;
        return Valid(root.left, root.val, min) && Valid(root.right, max, root.val);
    }
}
