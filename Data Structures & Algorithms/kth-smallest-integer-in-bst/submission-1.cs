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
    public int KthSmallest(TreeNode root, int k) {
        List<int> result = new();
        Dfs(root, result);
        return result[k - 1];   
      
    }

    public void Dfs(TreeNode root, IList<int> res)
    {
        if(root is null)
            return;
        
        Dfs(root.left, res);
        res.Add(root.val);
        Dfs(root.right, res);
    }
}
