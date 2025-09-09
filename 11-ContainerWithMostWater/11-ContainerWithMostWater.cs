// Last updated: 9/9/2025, 1:07:29 PM
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public bool HasCycle(ListNode head) {
        // two pointers, tortoise-hare method.
        if(head ==null) return false;
        var ptr=head;
        var ptr2=head.next;
        while(ptr2 !=null && ptr2.next!=null){
            if(ptr==ptr2){
                return true;
            }
            ptr=ptr.next;
            ptr2=ptr2.next.next;

        }
        return false;
    }
}