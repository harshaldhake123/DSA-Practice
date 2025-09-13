// Last updated: 9/13/2025, 10:06:06 PM
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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        //Two pointers, wait to increment one until n
        var dummy=new ListNode(0,head); // [dummy]-> [head]
        var left=dummy;
        var right=dummy;
        var i=0;
        while(i<n){
            right=right.next;
            i++;
        }

        while(right.next!=null){
            left=left.next;
            right=right.next;
        }
        // now left is at ['Element to Pop' - 1]th node
        left.next=left.next.next;
        return dummy.next;
    }
}