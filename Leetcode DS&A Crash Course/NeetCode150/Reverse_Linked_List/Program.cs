//Reverse Linked List
/*
Given the head of a singly linked list, reverse the list, and return the reversed list.

 

Example 1:

Input: head = [1,2,3,4,5]
Output: [5,4,3,2,1]
Example 2:

Input: head = [1,2]
Output: [2,1]
Example 3:

Input: head = []
Output: []
 

Constraints:

The number of nodes in the list is the range [0, 5000].
-5000 <= Node.val <= 5000
 

Follow up: A linked list can be reversed either iteratively or recursively. Could you implement both?
*/

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
//time complexity: O(n)
 //space complexity: O(1)
public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null; //prev node will be behind the current node
        ListNode curr= head; // current node will be set to the first node of the head

        if (head == null) return null; //if the head is null, return null

        while(curr != null) { //while head has noted
            ListNode temp = curr.next; //save node so we dont lose the rest of the list
            curr.next = prev; //reverse the current node to point backwards
            prev = curr; //move the prev forward with the value stored in current
            curr = temp; // move forward with curr.next value thats stored in temp
        }
            return prev; //reassign the head
    }
}
