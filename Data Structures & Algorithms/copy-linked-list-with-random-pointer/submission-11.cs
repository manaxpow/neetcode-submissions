/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        var dict = new Dictionary<Node, Node>();

        Node dummy = new Node(0);
        Node newHead = dummy;
        Node cur = head;
        while(cur!=null)
        {
            Node temp = new Node(cur.val);
            newHead.next = temp;
            if(cur is not null)
                dict[cur] = newHead.next;

            newHead=newHead.next;
            cur=cur.next;
        }

        cur = head;
        newHead = dummy;
        while(cur!=null)
        {
            newHead.next.random = cur.random != null ? dict.GetValueOrDefault(cur.random,null) : null;
            newHead=newHead.next;
            cur=cur.next;
        }

        return dummy.next;
    }
}
