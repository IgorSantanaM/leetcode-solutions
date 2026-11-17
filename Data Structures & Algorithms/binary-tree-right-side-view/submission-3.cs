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
    public List<int> RightSideView(TreeNode root) {
        var result = new List<int>();
        Dfs(root, 0, result);
        return result;
    }

    private void Dfs(TreeNode root, int depth, List<int> result)
    {
        if(root is null)
            return;
        if(result.Count == depth)
            result.Add(root.val);

        Dfs(root.right, depth + 1, result);
        Dfs(root.left, depth + 1, result);
    }
}
