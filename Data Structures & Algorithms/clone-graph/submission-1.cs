/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    private Dictionary<Node, Node> oldToNew = new Dictionary<Node, Node>();
    public Node CloneGraph(Node node) {
        if(node == null)
            return node;

        return Dfs(node);
    }

    private Node Dfs(Node originalNode)
    {
        if(oldToNew.ContainsKey(originalNode))
            return oldToNew[originalNode];
    
        var clone = new Node(originalNode.val);
        oldToNew.Add(originalNode, clone);
        foreach(var nei in originalNode.neighbors)
        {
            var cloneCopy = Dfs(nei);
            clone.neighbors.Add(cloneCopy);
        }

        return clone;
    }

}
