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
    public bool IsBalanced(TreeNode root) {
        bool isBalance = true;
        CalculateDepth(root,ref isBalance);
        return isBalance;
    }

    private int CalculateDepth(TreeNode node, ref bool isBalance)
    {
        if(node is null) return 0;
        int depthLeft = CalculateDepth(node.left,ref isBalance);
        int depthRight = CalculateDepth(node.right,ref isBalance);

        if(Math.Abs(depthLeft - depthRight) > 1) isBalance = false;
        return Math.Max(depthLeft,depthRight) +1;
    }
}
