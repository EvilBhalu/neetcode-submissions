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
    public TreeNode InvertTree(TreeNode root) 
    {
        if (root == null)
            return null;

        // var q = new Queue<TreeNode>();
        // q.Enqueue(root);

        // while (q.Count > 0)
        // {
        //     var n = q.Dequeue();

        //     Swap(n.left, n.right);

        //     if (n.left != null)
        //         q.Enqueue(n.left);

        //     if (n.right != null)
        //         q.Enqueue(n.right);
        // }    

        // return root;

        TreeNode temp = root.left;
        root.left = root.right;
        root.right = temp;

        InvertTree (root.left);
        InvertTree (root.right);

        return root;
    }

    private void Swap(TreeNode left, TreeNode right)
    {
        TreeNode temp;

        temp = left;
        left = right;
        right = temp;
    }
}
