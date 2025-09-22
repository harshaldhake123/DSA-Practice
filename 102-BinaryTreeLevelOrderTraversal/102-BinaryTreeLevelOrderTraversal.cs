// Last updated: 9/22/2025, 11:08:16 PM
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
    public IList<IList<int>> LevelOrder(TreeNode root) {
        var list=new List<IList<int>>();
        if(root==null){
            return list;
        }
        var queue=new Queue<TreeNode>();
        queue.Enqueue(root);
        while(queue.Count>0){
            var level=new List<int>();
            var count=queue.Count;
            for(int i=0;i<count;i++){
                var node = queue.Dequeue();
                level.Add(node.val);
                if(node.left!=null){
                    queue.Enqueue(node.left);
                }
                if(node.right!=null){
                    queue.Enqueue(node.right);
                }
            }
            if(level.Count>0){
                list.Add(level);
            }
        }
        return list;
    }
}