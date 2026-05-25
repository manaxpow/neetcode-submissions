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
    public List<List<int>> LevelOrder(TreeNode root) {
        var result = new List<List<int>>();
        if (root == null)
            return result;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int level = 0;
        while (queue.Count > 0) {
            var queueSize = queue.Count;
            var list = new List<int>(queue.Count);
            while (queueSize > 0) {
                var cur = queue.Dequeue();
                list.Add(cur.val);
                if (cur.left is not null)
                    queue.Enqueue(cur.left);
                if (cur.right is not null)
                    queue.Enqueue(cur.right);
                queueSize--;
            }
            result.Add(list);
            level++;
        }
        return result;
    }
}
