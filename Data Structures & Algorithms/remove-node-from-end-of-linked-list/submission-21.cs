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
        ListNode dummy = new ListNode(0);
        dummy.next = head;

        ListNode l = dummy, r= dummy.next;
        int length = 1;
        while(r.next != null)
        {
            if(length == n)
            {
                l=l.next;
            }
            else length++;

            r=r.next;
        }
        l.next=l.next.next;

        return dummy.next;
    }
}
