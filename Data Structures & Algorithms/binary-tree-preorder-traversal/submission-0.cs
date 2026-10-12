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
    
    List<int> res = new();
    
    public List<int> PreorderTraversal(TreeNode root) 
    {
        Pre(root);
        return res;
    }

    private void Pre(TreeNode n)
    {
        if (n == null)
            return;

        res.Add(n.val);

        Pre(n.left);
        Pre(n.right);
    }
}