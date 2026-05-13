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
    public ListNode ReverseList(ListNode head) {
        if(head == null) return head;

        ListNode preNode = null;
        ListNode curNode = head;

        while(curNode != null)
        {
            ListNode nextTemp = curNode.next;
            curNode.next= preNode;

            preNode = curNode;
            curNode = nextTemp;
        }
        return preNode;
    }
}
