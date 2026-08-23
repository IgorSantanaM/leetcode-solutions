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
    public bool IsSameTree(TreeNode p, TreeNode q) 
    => SameTree(p, q);
    public bool SameTree(TreeNode? p, TreeNode? q) {
        if(p is null && q is null)
            return true;
        if(p is null  || q is null)
            return false;
        if(p.val != q.val)
            return false;
        return SameTree(p.left, q.left) && SameTree(p.right, q.right);
    }
}
