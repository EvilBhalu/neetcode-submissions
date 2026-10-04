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
    public int MaxDepth(TreeNode root) 
    {
        int depth = 0;

        if (root == null)
            return depth;

        //depth = 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));

        var q = new Queue<TreeNode>();
        q.Enqueue(root);

        while (q.Count > 0)
        {
            int size = q.Count;

            for (int i=0; i<size; i++)
            {
                var n = q.Dequeue();

                if(n.left != null)
                    q.Enqueue(n.left);

                if(n.right != null)
                    q.Enqueue(n.right);
            }

            depth++;
        }

        return depth;
    }
}
