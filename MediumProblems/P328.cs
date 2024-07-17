/* https://leetcode.com/problems/odd-even-linked-list/description/?envType=study-plan-v2&envId=leetcode-75 */

public class Solution {
    public ListNode OddEvenList(ListNode head) {
        if (head == null || head.next == null) {
            return head;
        }
        ListNode odd_Node = head;
        ListNode even_Node = head.next;
        ListNode temp_Node = even_Node;
        while(odd_Node.next!=null && even_Node.next != null){
            odd_Node.next = even_Node.next;
            odd_Node = odd_Node.next;
            even_Node.next = odd_Node.next;
            even_Node = even_Node.next;
        }
        odd_Node.next = temp_Node;
        return head;
    }
} 
