// Last updated: 9/11/2025, 10:38:15 PM
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
        Console.WriteLine(root.val);
        var leftHeight=Height(root.left);
        var rightHeight=Height(root.right);
        Console.WriteLine("leftHeight"+leftHeight+"\trightHeight: "+rightHeight);
        if(Math.Abs(leftHeight-rightHeight)>1){
            return false;
        }
        return IsBalanced(root.left) &&IsBalanced(root.right);
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