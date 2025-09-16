// Last updated: 9/16/2025, 10:33:43 PM
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
        if(root==null){
            return null;
        }
        //BFS using queue
        var queue=new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count>0){
            var node=queue.Dequeue();
            var left=node.left;
            node.left=node.right;
            node.right=left;
            if(node.left!=null) queue.Enqueue(node.left);
            if(node.right!=null) queue.Enqueue(node.right);
        }
        return root;
    }

    public TreeNode InvertTreeStack(TreeNode root) {
        if(root==null){
            return null;
        }
        //DFS, Using stack instead of recursion
        var stack=new Stack<TreeNode>();
        stack.Push(root);
        while(stack.Count>0){
            var node=stack.Pop();
            var left=node.left;
            node.left=node.right;
            node.right=left;
            if(node.left!=null) stack.Push(node.left);
            if(node.right!=null) stack.Push(node.right);
        }
        return root;
    }

    public TreeNode InvertTreeInOrder(TreeNode root) {
        //swap right and left nodes of root, 
        // recursively swap each right and left node 
        if(root==null){
            return null;
        }
        //DFS, Inorder because root is processed before its left and right.
        TreeNode temp;
        temp=root.right;
        root.right=root.left;
        root.left=temp;

        InvertTree(root.right);
        InvertTree(root.left);
        return root;
    }
}