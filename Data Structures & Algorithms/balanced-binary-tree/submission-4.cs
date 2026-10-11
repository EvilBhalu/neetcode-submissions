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
        // bool isBal = true;
        // GetTreeHeight(root, ref isBal);
        // return isBal;   

        if (root == null)
            return true;

        int leftH = Height (root.left);
        int rightH = Height (root.right);

        if (Math.Abs(leftH - rightH) > 1 || !IsBalanced(root.left) || !IsBalanced (root.right))
            return false;
        else
            return true;
    }

    private int Height(TreeNode n)
    {
        if (n == null)
            return 0;

        return 1 + Math.Max(Height(n.left), Height(n.right));
    }

    // 1 pass solution would follow the same pattern as Diameter
    // it would combine the check within the height
    // declare isBal = true, isBal &= Math.Abs(leftHeight - rightHeight) <= 1

    // private int GetTreeHeight(TreeNode root, ref bool isBal)
    // {
    //     if(root == null)
    //         return 0;

    //     int leftHeight = GetTreeHeight(root.left, ref isBal);
    //     int rightHeight = GetTreeHeight(root.right, ref isBal);
    //     isBal = isBal & Math.Abs(leftHeight - rightHeight) <= 1;
    //     //Console.WriteLine($"{root.val},{leftHeight - rightHeight},{isBal}");
    //     return Math.Max(leftHeight, rightHeight) + 1;
    // }
}
