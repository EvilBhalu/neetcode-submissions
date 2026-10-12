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
    // public bool IsValidBST(TreeNode root) 
    // {
    //     return Check(root, long.MinValue, long.MaxValue);
    // }

    // private bool Check(TreeNode n, long low, long high)
    // {
    //     if (n == null)
    //         return true;

    //     if (n.val <= low || n.val >= high)
    //         return false;

    //     return Check (n.left, low, n.val) && Check (n.right, n.val, high);
    // }

    //BFS
    public bool IsValidBST(TreeNode root)
    {
        if (root == null)
            return true;

        Queue <(TreeNode, long, long)> myq = new();
        myq.Enqueue((root, long.MinValue, long.MaxValue));

        while (myq.Count > 0)
        {
            var (node, low, high) = myq.Dequeue();

            if (!(low < node.val && node.val < high))
                return false;

            if (node.left != null)
                myq.Enqueue ((node.left, low, node.val));

            if (node.right != null)
                myq.Enqueue ((node.right, node.val, high));
        }

        return true;
    }
}
