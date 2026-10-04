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
    public bool IsBalanced(TreeNode root) 
    {
        bool isBal = true;
        GetTreeHeight(root, ref isBal);
        return isBal;   
    }

    private int GetTreeHeight(TreeNode root, ref bool isBal)
    {
        if(root == null)
            return 0;

        int leftHeight = GetTreeHeight(root.left, ref isBal);
        int rightHeight = GetTreeHeight(root.right, ref isBal);
        isBal = isBal & Math.Abs(leftHeight - rightHeight) <= 1;
        //Console.WriteLine($"{root.val},{leftHeight - rightHeight},{isBal}");
        return Math.Max(leftHeight, rightHeight) + 1;
    }
}
