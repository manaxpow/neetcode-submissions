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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(p.val < q.val) return IsLCA(root,p,q);
        return IsLCA(root,q,p);
    }

    private TreeNode IsLCA(TreeNode node,TreeNode p, TreeNode q)
    {
        if(node.val >= p.val && node.val <= q.val) return node;
        if(node.val > p.val && node.val > q.val) return IsLCA(node.left,p,q);
        else return IsLCA(node.right,p,q);
    }
}
