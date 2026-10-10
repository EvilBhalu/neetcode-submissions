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
    public bool HasCycle(ListNode head) 
    {
        // Solution 1
        // HashSet<ListNode> seen = new HashSet<ListNode>();

        // while (head != null)
        // {
        //     if (seen.Contains(head))
        //         return true;
        //     else
        //         seen.Add(head);

        //     head = head.next;
        // }    
        // return false;

        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;

            if (slow.Equals(fast))
                return true;
        }

        return false;
    }
}
