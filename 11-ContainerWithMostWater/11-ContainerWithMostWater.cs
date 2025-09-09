// Last updated: 9/9/2025, 1:14:12 PM
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
    public bool HasCycle(ListNode? head)
    {
        if (head == null) return false;

        ListNode? slow = head, fast = head;
        while (fast?.next != null)
        {
            slow = slow?.next;
            fast = fast.next?.next;

            if (slow == fast) return true;
        }

        return false;
    }
}