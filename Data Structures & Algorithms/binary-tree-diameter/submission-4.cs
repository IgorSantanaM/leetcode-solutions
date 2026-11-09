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
    public int DiameterOfBinaryTree(TreeNode root) {
        int max = 0;

        int Dfs(TreeNode r)
        {
            if(r is null)
                return 0;
            int left = Dfs(r.left);
            int right = Dfs(r.right);

            max = Math.Max(max, left + right);
            return 1 + Math.Max(left, right);
        }
        
        Dfs(root);

        return max;
    }
}
