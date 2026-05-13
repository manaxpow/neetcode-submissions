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

public class Solution
{
    public void ReorderList(ListNode head)
    {
        if (head == null) return;
        // finding N
        int n = 0;
        ListNode l2 = head;
        while (l2 != null)
        {
            n++;
            l2 = l2.next;
        }

        // finding halves of n
        int halvesN = n % 2 == 1 ? n / 2 + 1 : n / 2;
        int curNode = 1;
        l2 = head;

        while (curNode != halvesN)
        {
            l2 = l2.next;
            curNode++;
        }

        // separate linked list into 2 halves and then reverse the right ones
        ListNode cur = l2;
        l2 = l2.next;
        cur.next = null;

        ListNode pre = null;
        while (l2 != null)
        {
            ListNode next = l2.next;
            l2.next = pre;
            pre = l2;
            l2 = next;
        }

        ListNode l1 = head;
        l2 = pre;
        while (l2 != null)
        {
            ListNode n1 = l1.next;
            ListNode n2 = l2.next;

            l1.next = l2;
            l2.next = n1;

            l1 = n1;
            l2 = n2;
        }
        return;
    }
}