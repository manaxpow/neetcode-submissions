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
    public bool HasCycle(ListNode head) {
        if(head == null) return false;

        ListNode cur = head;
        while(cur!= null)
        {
            if(cur.val == 1001) return true;
            cur.val = 1001;
            cur = cur.next;
        }

        return false;
    }
}
