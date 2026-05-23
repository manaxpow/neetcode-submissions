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
    public TreeNode InvertTree(TreeNode root) {
        if (root is null)
            return root;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0) {
            var cur = queue.Dequeue();
            // next when the node is a leaf
            if (cur.left is null && cur.right is null)
                continue;

            // revert
            var temp = cur.left;
            cur.left = cur.right;
            cur.right = temp;
            
            // add to the queue
            if (cur.left is not null)
                queue.Enqueue(cur.left);
            if (cur.right is not null)
                queue.Enqueue(cur.right);
        }
        return root;
    }
}
