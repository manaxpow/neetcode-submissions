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
    public List<int> RightSideView(TreeNode root) {
        var result = new List<int>();
        if (root is null)
            return result;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0) {
            int queueSize = queue.Count;
            while (queueSize > 0) {
                var cur = queue.Dequeue();
                if (queueSize == 1) {
                    result.Add(cur.val);
                }

                if (cur.left is not null)
                    queue.Enqueue(cur.left);
                if (cur.right is not null)
                    queue.Enqueue(cur.right);
                queueSize--;
            }
        }

        return result;
    }
}
