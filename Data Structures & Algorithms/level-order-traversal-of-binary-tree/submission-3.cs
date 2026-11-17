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
    public List<List<int>> LevelOrder(TreeNode root) {
        var res = new List<List<int>>();
        if(root is null)
            return res;
        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count > 0)
        {
            var currentCount = q.Count;
            var currentList = new List<int>();
            for(int i = 0; i < currentCount; i++)
            {
                var current = q.Dequeue();
                currentList.Add(current.val);
                if(current.left != null)
                    q.Enqueue(current.left);
                if(current.right != null)
                    q.Enqueue(current.right);
            }
            res.Add(currentList);
        }
        return res;
    }
}
