// Last updated: 9/11/2025, 9:57:04 PM
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
        if(root == null){
            return true;
        }
        var leftHeight=Height(root.left);
        var rightHeight=Height(root.right);

        if(Math.Abs(leftHeight-rightHeight)>1){
            return false;
        }
        var leftBalanced=IsBalanced(root.left);
        var rightBalanced=IsBalanced(root.right);
        if(!(leftBalanced && rightBalanced)){
            return false;
        }
        return true;
    }

    private int Height(TreeNode root){
        if(root ==null){
            return 0;
        }
        var leftHeight=Height(root.left);
        var rightHeight=Height(root.right);
        return Math.Max(leftHeight,rightHeight)+1;
    }
}