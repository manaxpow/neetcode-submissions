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
    public int GoodNodes(TreeNode root) {
        return CountGoodNodes(root, root.val);
    }

    private int CountGoodNodes(TreeNode node, int max) {
        if (node is null)
            return 0;
        if (node.val >= max) {
            max = node.val;
            return 1 + CountGoodNodes(node.left, max) + CountGoodNodes(node.right, max);
        } else
            return CountGoodNodes(node.left, max) + CountGoodNodes(node.right, max);
    }
}
