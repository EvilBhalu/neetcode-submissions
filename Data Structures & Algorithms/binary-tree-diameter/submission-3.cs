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
    
    int best;

    public int DiameterOfBinaryTree(TreeNode root) 
    {
        // var l = new List<int>();
        // GetTreeHeight(root, l);

        // int max = l[0];
        // foreach(var v in l)
        // {
        //     if(v > max)
        //         max = v;
        // }
        // return max;

        best = 0;
        //Visit(root);
        Height(root);
        return best;
    }

    // This version is O(n^2) complexity because it visits and then finds the height
    // We can do a one pass version with no Visit and only Height
    // void Visit (TreeNode root)
    // {
    //     if (root == null)
    //         return;

    //     int through = Height(root.left) + Height (root.right);
    //     best = Math.Max(best, through);

    //     Visit (root.left);
    //     Visit (root.right);
    // }

    int Height (TreeNode root)
    {
        if (root == null)
            return 0;

        int left = Height (root.left);
        int right = Height (root.right);
        best = Math.Max (best, left + right);

        return 1 + Math.Max (left, right);
        // return 1 + Math.Max(Height(root.left), Height(root.right));
    }

    // public int GetTreeHeight(TreeNode root, List<int> l)
    // {
    //     if (root == null)
    //         return 0;

    //     int leftHeight = GetTreeHeight(root.left, l);
    //     int rightHeight = GetTreeHeight(root.right, l);
    //     l.Add(leftHeight+rightHeight);
    //     return Math.Max(leftHeight, rightHeight) + 1;
    // }
}
