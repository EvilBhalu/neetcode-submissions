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
    public ListNode RemoveNthFromEnd(ListNode head, int n) 
    {
        ListNode dummy = new();
        dummy.next = head;
        ListNode slow = dummy;
        ListNode fast = dummy;

        // step 1: loop until gap of n
        for (int i=0; i<n; i++)
        {
            fast = fast.next;
        }

        // step 2: loop until end
        while (fast.next != null)
        {
            fast = fast.next;
            slow = slow.next;
        }

        // step 3: delete node
        ListNode temp = slow.next;
        slow.next = temp.next;

        return dummy.next;                                              
    }
}
