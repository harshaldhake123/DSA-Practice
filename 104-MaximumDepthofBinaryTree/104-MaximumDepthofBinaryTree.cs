// Last updated: 9/10/2025, 10:36:12 PM
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
    // BFS
    public int MaxDepth(TreeNode root) {
        if(root==null){
            return 0;
        }
        var lDepth= MaxDepth(root.left);
        var rDepth=MaxDepth(root.right);
        return Math.Max(lDepth,rDepth)+1;
    }
}