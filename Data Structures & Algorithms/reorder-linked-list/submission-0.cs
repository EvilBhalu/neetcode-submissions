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
    public void ReorderList(ListNode head) 
    {
        ListNode curr = head;

        while (curr.next != null && curr.next.next != null)
        {
            ListNode temp = curr.next;

            ListNode slow = curr;
            ListNode fast = curr.next;
            while(fast.next != null)
            {
                slow = slow.next;
                fast = fast.next;
            }
            ListNode prev = slow;
            ListNode tail = fast;

            prev.next = null;
            tail.next = temp;
            curr.next = tail;
            curr = temp;
        }            
    }
}
