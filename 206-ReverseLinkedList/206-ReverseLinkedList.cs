// Last updated: 9/9/2025, 5:20:08 PM
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        var stack = new Stack<int>();
        var temp=head;

        while(temp!=null){
            stack.Push(temp.val);
            temp=temp.next;
        }
        temp=head;

        while(temp!=null){
            temp.val=stack.Pop();
            temp=temp.next;
        }
        return head;
    }
}