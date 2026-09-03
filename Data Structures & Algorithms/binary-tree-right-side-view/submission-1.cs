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
    List<int> result = new();
    public List<int> RightSideView(TreeNode root) {
        Dfs(root, 0);
        return result;
    }

    private void Dfs(TreeNode node, int depth)
    {
        if(node is null)
            return;

        if(result.Count == depth)
            result.Add(node.val);
        
        Dfs(node.right, depth + 1);
        Dfs(node.left, depth + 1);
    }
}
