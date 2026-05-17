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
        int length =0;
        ListNode temp = head;
        // finding count of linked list
        while(temp != null)
        {
            temp = temp.next;
            length++;
        }

        ListNode dummy = new ListNode(0);
        dummy.next = head;
        ListNode cur = dummy;

        int move = length -n;
        // move to node before removal node
        for(int i=0;i<move;i++)
        {
            cur = cur.next;
        }
        // remove node 
        cur.next = cur.next.next;

        return dummy.next;
    }
}
