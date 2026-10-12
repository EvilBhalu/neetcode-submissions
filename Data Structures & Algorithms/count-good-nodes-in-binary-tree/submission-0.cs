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

    int res;

    public int GoodNodes(TreeNode root) 
    {
        res = 0;
        DFS (root, int.MinValue);
        return res;
    }

    private void DFS (TreeNode n, int maxSoFar)
    {
        if (n == null)
            return;

        // do something
        maxSoFar = Math.Max(n.val, maxSoFar);
        if (n.val >= maxSoFar)
            res++;

        DFS(n.left, maxSoFar);
        DFS(n.right, maxSoFar);
    }
}
