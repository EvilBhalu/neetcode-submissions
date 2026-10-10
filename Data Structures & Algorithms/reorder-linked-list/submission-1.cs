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
        // BRUTE FORCE SOLUTION
        // ListNode curr = head;

        // while (curr.next != null && curr.next.next != null)
        // {
        //     ListNode temp = curr.next;

        //     ListNode slow = curr;
        //     ListNode fast = curr.next;
        //     while(fast.next != null)
        //     {
        //         slow = slow.next;
        //         fast = fast.next;
        //     }
        //     ListNode prev = slow;
        //     ListNode tail = fast;

        //     prev.next = null;
        //     tail.next = temp;
        //     curr.next = tail;
        //     curr = temp;
        // }  

        // Step 1: Find the middle and split the list in two halves
        ListNode slow = head;
        ListNode fast = head.next;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }        
        ListNode head2 = slow.next;
        slow.next = null;

        // Step 2: Reverse the second half list 
        ListNode curr = head2;
        ListNode prev = null;
        while (curr != null)
        {
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }
        head2 = prev;

        // Step 3: Merge two halves together: head and head2
        while (head2 != null)
        {
            ListNode temp = head.next;
            ListNode temp2 = head2.next;

            head.next = head2;
            head2.next = temp;

            head = temp;
            head2 = temp2;
        }
    }
}
