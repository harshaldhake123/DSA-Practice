// Last updated: 9/9/2025, 6:09:04 PM
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

    public ListNode ReverseList(ListNode head){
        if(head ==null || head.next ==null){
            return head;
        }

        var newHead=ReverseList(head.next);
        var front=head.next;
        front.next=head;
        head.next=null;
        return newHead;
    }
    // SC: O(1), TC: O(1)
    public ListNode ReverseListIterativeO1SpaceComplexity(ListNode head) {
        ListNode current=head, previous=null, front=null;
        while(current!=null){
            front=current.next;
            current.next=previous;
            previous=current;
            current=front;
        }
        return previous;
    }

    ///SC: O(N), TC: O(2N)=> O(N)
    public ListNode ReverseListIterative(ListNode head) {
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