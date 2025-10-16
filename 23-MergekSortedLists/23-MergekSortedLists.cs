// Last updated: 10/16/2025, 10:45:07 PM
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
    public ListNode MergeKLists(ListNode[] lists) {
        if(lists ==null || lists.Length==0) return null;
        return Merge(lists, 0, lists.Length-1);
    }

    // merge all that recursively calls itself and base case is to call merge two lists
    private ListNode Merge(ListNode[] lists, int start, int end){
        if(start==end){ 
            return lists[start];
        }
        var mid = start+ (end-start)/2;
        var l1=Merge(lists, start, mid);
        var l2=Merge(lists,mid+1, end);
        return MergeTwoSortedLists(l1, l2);
    }

    private ListNode MergeTwoSortedLists(ListNode l1, ListNode l2){
       var dummy=new ListNode();
       var current=dummy;
       var curr1=l1;
       var curr2=l2;
       while(curr1!=null && curr2!=null){
        if(curr1.val < curr2.val){
            current.next=curr1;
            curr1=curr1.next;
        }else{
            current.next=curr2;
            curr2=curr2.next;
        }
        current=current.next;
       }
       current.next=curr1!=null? curr1:curr2;
       return dummy.next;
    }
}