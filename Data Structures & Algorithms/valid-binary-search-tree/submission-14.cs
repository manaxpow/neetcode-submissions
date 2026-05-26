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
    public bool IsValidBST(TreeNode root) {
        return IsValid(root, Int32.MaxValue, Int32.MinValue);
    }

    private bool IsValid(TreeNode node, int max,int min) {
        if (node is null)
            return true;

        if(node.val <= min || node.val >= max) return false;

        return IsValid(node.left, node.val, min) && IsValid(node.right, max, node.val);
    }
}
