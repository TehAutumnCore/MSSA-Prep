﻿//Linked List Cycle
/*
Given head, the head of a linked list, determine if the linked list has a cycle in it.

There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer. Internally, pos is used to denote the index of the node that tail's next pointer is connected to. Note that pos is not passed as a parameter.

Return true if there is a cycle in the linked list. Otherwise, return false.

 

Example 1:


Input: head = [3,2,0,-4], pos = 1
Output: true
Explanation: There is a cycle in the linked list, where the tail connects to the 1st node (0-indexed).
Example 2:


Input: head = [1,2], pos = 0
Output: true
Explanation: There is a cycle in the linked list, where the tail connects to the 0th node.
Example 3:


Input: head = [1], pos = -1
Output: false
Explanation: There is no cycle in the linked list.
 

Constraints:

The number of the nodes in the list is in the range [0, 104].
-105 <= Node.val <= 105
pos is -1 or a valid index in the linked-list.
 

Follow up: Can you solve it using O(1) (i.e. constant) memory?
*/

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
//Time Complexity: O(n)
//Space Complexity: O(1)

//Solution:
public class Solution {
    public bool HasCycle(ListNode head) {
    if (head == null) { //if head is null or empty
        return false;
    }
    //if fast != null && fast.next != null return false
    //if slow == fast return true
       ListNode slow = head; //creates a slower pointer
       ListNode fast = head; //creates a fast pointer

       while (fast != null && fast.next != null) { //while fast != null, so doesnt reach an end
        slow = slow.next; //slow pointer will move 1 step
        fast = fast.next.next; //fast pointer will move 2 steps
        if (slow == fast) { //if fast overlaps slow that means there was a cycle
            return true; //return true if there is a cycle
            }
        }
        return false; //return false if there is no cycle
    }
}