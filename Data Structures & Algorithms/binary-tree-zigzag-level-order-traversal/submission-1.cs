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
    public List<List<int>> ZigzagLevelOrder(TreeNode root) 
    {
        List<List<int>> outer = new();
     
        if (root == null)
            return outer; 
     
        Queue<TreeNode> myq = new();
        myq.Enqueue (root);

        while (myq.Count != 0)
        {
            List<int> inner = new();
            int size = myq.Count;

            for(int i=0; i<size; i++)
            {
                var node = myq.Dequeue();

                inner.Add(node.val);

                if (node.left != null) myq.Enqueue(node.left);
                if (node.right != null) myq.Enqueue(node.right);
            }

            outer.Add(inner);
        }

        for (int i=0; i<outer.Count; i++)
        {
            if (i % 2 == 0)
            {
                continue;
            }
            else
            {
                outer[i].Reverse();
            }
        }

        return outer;    
    }
}