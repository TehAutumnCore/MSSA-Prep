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

//Time Complexity: O(n+m) <- n= number of nodes in list 1, m=number of nodes in list2
//Space Complexity: O(1)
 
public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    { //takes two sorted lists
        ListNode dummy = new ListNode(0); //start of the result list, like an empty list named answer []
        ListNode current = dummy; //used to build the new list

        while (list1 != null && list2 != null)
        { //as long as list1 and list 2 have nodes, continue running the loop
            if (list1.val <= list2.val)
            { //compare the values of the current nodes in each list
                current.next = list1; //attach the smaller node to current.next, and if the values are equal attach list1
                list1 = list1.next; //move pointer forward in the list
            }
            else
            {
                current.next = list2; //if list1.val > list2.val attach list2 node to current.next
                list2 = list2.next; //move pointer forward in the list
            }
            current = current.next; //move current forward so the next node you attach goes to the end of the merged list
        }

        current.next = (list1 != null) ? list1 : list2; //ternary statement, if (list1 != null) then {current.next=list1}   else{list2 != null) then {current.next=list2}
        return dummy.next; //returns the start of the merged list. skipping the dummy node and returning the value afterwards
    }
}