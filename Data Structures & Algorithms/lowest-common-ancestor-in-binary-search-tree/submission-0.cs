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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) 
    {
        //val to check is in left subtree
        if (p.val < root.val && q.val < root.val)
            return LowestCommonAncestor(root.left, p, q);

        //val to check is in right subtree
        if (p.val > root.val && q.val > root.val)
            return LowestCommonAncestor(root.right, p, q);
        
        //val is current root itself
        return root;    
    }
}
