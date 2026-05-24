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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        if(root is null ) return false;
        if(IsSub(root,subRoot)) return true;
        return IsSubtree(root.left,subRoot) || IsSubtree(root.right,subRoot);
    }

    private bool IsSub(TreeNode node, TreeNode subNode)
    {
        if(node is null && subNode is null ) return true;
        if(!(node is null == subNode is null)) return false;
        if(node.val != subNode.val) return false;

        return IsSub(node.left, subNode.left) && IsSub(node.right, subNode.right);
    }
}
