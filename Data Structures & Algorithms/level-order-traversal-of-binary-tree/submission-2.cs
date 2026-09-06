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
       var result = new List<List<int>>();
       if(root is null)
        return result;
       Lot(root, result);
       return result; 
    }

    private void Lot(TreeNode root, IList<List<int>> res)
    {
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while(queue.Count > 0)
        {
            var currentCount = queue.Count;
            var currentResult = new List<int>();
            
            for(int i = 0; i < currentCount; i++)
            {
                var current = queue.Dequeue();
                currentResult.Add(current.val);

                if(current.left != null)
                    queue.Enqueue(current.left);
                
                if(current.right != null)
                    queue.Enqueue(current.right);
            }

            res.Add(new List<int>(currentResult));
        }
    }
}
