// Last updated: 9/18/2025, 10:24:43 PM
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
    public IList<int> InorderTraversal(TreeNode root) {
        // Inorder = left, root, right
        var list=new List<int>();
        var stack=new Stack<TreeNode>();
      var  current=root;
        while(current!=null || stack.Count>0){
            while(current!=null){
                stack.Push(current);
                current=current.left;
            }
            current=stack.Pop();
            list.Add(current.val);
            current=current.right;
        }
        return list;
    }
}