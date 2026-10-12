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
    public bool IsValidBST(TreeNode root) 
    {
        return Check(root, long.MinValue, long.MaxValue);
    }

    private bool Check(TreeNode n, long low, long high)
    {
        if (n == null)
            return true;

        if (n.val <= low || n.val >= high)
            return false;

        return Check (n.left, low, n.val) && Check (n.right, n.val, high);
    }
}
