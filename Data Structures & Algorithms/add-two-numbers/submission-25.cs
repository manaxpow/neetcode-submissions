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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0);
        ListNode cur = dummy;
        int count = 0;
        while(l1 != null && l2 != null)
        {
            int l1Value = l1.val ;
            int l2Value = l2.val ;
            
            ListNode temp = new ListNode();
            // calculating add
            temp.val = (l1Value + l2Value) % 10 + count;
            count = (l1Value + l2Value) / 10;
            cur.next = temp;

            // move
            cur = cur.next;
            if(l1.next == null || l2.next == null) break;
            l1= l1.next;
            l2= l2.next;
        }

        ListNode expand = null;
        if(l1.next != null) expand = l1.next;
        else if(l2.next != null) expand = l2.next;
        while(expand!=null)
        {
            int temp2 = expand.val;
            expand.val = (temp2 + count)%10;
            count = (temp2 + count)/10;
            cur.next=expand;

            cur=cur.next;
            expand=expand.next;
        }
        if(count>0)
        {
            ListNode tail = new ListNode(count);
            cur.next = tail;
        }
        return dummy.next;
    }
}
