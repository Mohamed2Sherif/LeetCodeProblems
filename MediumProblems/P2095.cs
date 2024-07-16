/* You are given the head of a linked list. Delete the middle node, and return the head of the modified linked list.

The middle node of a linked list of size n is the ⌊n / 2⌋th node from the start using 0-based indexing, where ⌊x⌋ denotes the largest integer less than or equal to x.

For n = 1, 2, 3, 4, and 5, the middle nodes are 0, 1, 1, 2, and 2, respectively.
 

Example 1:


Input: head = [1,3,4,7,1,2,6]
Output: [1,3,4,1,2,6]
Explanation:
The above figure represents the given linked list. The indices of the nodes are written below.
Since n = 7, node 3 with value 7 is the middle node, which is marked in red.
We return the new list after removing this node. */



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
    public ListNode DeleteMiddle(ListNode head) {
        if (head == null || head.next == null) {
            return null; // If there is only one node or the list is empty, return null.
        }

        ListNode current, previous;
        int length = 1;
        current = head;

        while (current.next != null) {
            length += 1;
            current = current.next;
        }

        int removed_node_index = length / 2;
        current = head.next;
        previous = head;

        for (int i = 1; i < removed_node_index; i++) {
            current = current.next;
            previous = previous.next;
        }
        
        previous.next = current.next;

        return head; 
    }
}
