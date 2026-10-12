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

    // DFS
    // int res;

    // public int GoodNodes(TreeNode root) 
    // {
    //     res = 0;
    //     DFS (root, int.MinValue);
    //     return res;
    // }

    // private void DFS (TreeNode n, int maxSoFar)
    // {
    //     if (n == null)
    //         return;

    //     // do something
    //     maxSoFar = Math.Max(n.val, maxSoFar);
    //     if (n.val >= maxSoFar)
    //         res++;

    //     DFS(n.left, maxSoFar);
    //     DFS(n.right, maxSoFar);
    // }

    // BFS
    public int GoodNodes(TreeNode root)
    {
        int res = 0;
        Queue<(TreeNode, int)> q = new();
        q.Enqueue((root, int.MinValue));

        while (q.Count > 0)
        {
            var (node, maxVal) = q.Dequeue();

            if (node.val >= maxVal)
                res++;

            if (node.left != null)
                q.Enqueue((node.left, Math.Max(maxVal, node.val)));

            if (node.right != null)
                q.Enqueue((node.right, Math.Max(maxVal, node.val)));
        }

        return res;
    }
}
