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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(subRoot is null)
            return true;
        
        if(root is null)
            return false;
        
        if(SameTree(root, subRoot))
            return true;
        return IsSubtree(root.left, subRoot) ||
                IsSubtree(root.right, subRoot);
    }

    public bool SameTree(TreeNode root, TreeNode subRoot)
    {
        if(root is null && subRoot is null)
            return true;
        
        if(root is null || subRoot is null)
            return false;

        if(root.val != subRoot.val)
            return false;
        
        return SameTree(root.left, subRoot.left) &&
                SameTree(root.right, subRoot.right);
    }
}
