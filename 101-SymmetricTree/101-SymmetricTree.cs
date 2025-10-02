// Last updated: 10/2/2025, 9:57:00 PM
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
    public bool IsSymmetric(TreeNode root) {
        return IsSymmetric(root.left,root.right);
    }

    public bool IsSymmetric(TreeNode node1, TreeNode node2){
        if(node1==null && node2==null) return true;
        if(node1==null || node2==null) return false;
        if(node1.val != node2.val) return false;
        return IsSymmetric(node1.left, node2.right)
        && IsSymmetric(node1.right, node2.left);
    }
}