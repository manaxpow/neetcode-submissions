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
    public int DiameterOfBinaryTree(TreeNode root) {
        int maxDiameter = 0;
        CalculateDepth(root, ref maxDiameter);
        return maxDiameter;
    }

    private int CalculateDepth(TreeNode node, ref int maxDiameter) {
        if (node is null)
            return 0;

        int maxLeft = CalculateDepth(node.left, ref maxDiameter);
        int maxRight = CalculateDepth(node.right, ref maxDiameter);

        maxDiameter = Math.Max(maxDiameter, maxLeft + maxRight);
        return Math.Max(maxLeft, maxRight) + 1;
    }
}
