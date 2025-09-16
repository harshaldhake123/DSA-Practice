// Last updated: 9/16/2025, 10:00:42 PM
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
    public TreeNode InvertTree(TreeNode root) {
        //swap right and left nodes of root, 
        // recursively swap each right and left node 
        if(root==null){
            return null;
        }
        //DFS
        TreeNode temp;
        temp=root.right;
        root.right=root.left;
        root.left=temp;

        InvertTree(root.right);
        InvertTree(root.left);
        return root;
    }
}