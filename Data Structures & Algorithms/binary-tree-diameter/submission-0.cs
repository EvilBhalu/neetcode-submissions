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
    public int DiameterOfBinaryTree(TreeNode root) 
    {
        //int d = 0;
        var l = new List<int>();
        //GetTreeHeight(root, ref d);
        GetTreeHeight(root, l);
        //return d;
        int max = l[0];
        foreach(var v in l)
        {
            if(v > max)
                max = v;
        }
        return max;
    }

    public int GetTreeHeight(TreeNode root, ref int d)
    {
        if (root == null)
            return 0;

        int leftHeight = GetTreeHeight(root.left, ref d);
        int rightHeight = GetTreeHeight(root.right, ref d);
        d = Math.Max(d, leftHeight + rightHeight);
        return Math.Max(leftHeight, rightHeight) + 1; 
    }

    public int GetTreeHeight(TreeNode root, List<int> l)
    {
        if (root == null)
            return 0;

        int leftHeight = GetTreeHeight(root.left, l);
        int rightHeight = GetTreeHeight(root.right, l);
        l.Add(leftHeight+rightHeight);
        return Math.Max(leftHeight, rightHeight) + 1;
    }
}
