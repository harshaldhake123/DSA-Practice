// Last updated: 9/18/2025, 10:18:20 PM
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
    public int KthSmallest(TreeNode root, int k) {
        var stack=new Stack<TreeNode>();
        var current=root;
        var n=0;
        while(current!=null || stack.Count>0){
            while(current !=null){
                stack.Push(current);
                current=current.left;
            }
            current=stack.Pop();// this is the smallest element in each iteration
            n+=1;
            if(n==k){
                return current.val;
            }
            current=current.right;
        }
        return current.val;
    }
}