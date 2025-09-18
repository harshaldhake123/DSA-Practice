// Last updated: 9/18/2025, 10:50:56 PM
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
        var count=0;
        int ans=0;
        traverse(root,ref count,ref ans, k);
        return ans;

    }
    private void traverse(TreeNode root,ref int count,ref int ans, int k){
        if(root ==null) return;
        this.traverse(root.left,ref count,ref ans, k);
        count++;
        if(count==k){
            ans=root.val;
            return;
        }
        this.traverse(root.right,ref count,ref ans,k);

    }
    public int KthSmallestStack(TreeNode root, int k) {
        var n=0;
        var current=root;
        var stack=new Stack<TreeNode>();
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