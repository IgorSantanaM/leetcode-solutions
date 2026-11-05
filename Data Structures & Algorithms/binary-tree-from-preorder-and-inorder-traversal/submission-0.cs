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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        TreeNode head = new TreeNode(0);
        TreeNode curr = head;
        int i = 0, j = 0, n = preorder.Length;

        while (i < n && j < n) {
            curr.right = new TreeNode(preorder[i], null, curr.right);
            curr = curr.right;
            i++;
            while (i < n && curr.val != inorder[j]) {
                curr.left = new TreeNode(preorder[i], null, curr);
                curr = curr.left;
                i++;
            }
            j++;
            while (curr.right != null && j < n && curr.right.val == inorder[j]) {
                TreeNode prev = curr.right;
                curr.right = null;
                curr = prev;
                j++;
            }
        }
        return head.right;
    }
}
