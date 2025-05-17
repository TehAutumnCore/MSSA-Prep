using System;

namespace Algorithms
{
    class CustomLinkedList
    {

        Node head; //represents the first item in the list

        public class Node
        {
            public int data;
            public Node next;

            public Node(int d) { data = d; }
        }

        //Time complexity: O(n)
        // Space Complexity: 0((1))
        public void deleteBackHalf()
        {

            if (head == null || head.next == null)
            {
                head = null;
                return;
            }

            Node slow = head; //will reach middle, when fast reaches end.
            Node fast = head; //will move twice as fast until it reaches the end
            Node prev = null; //will be behind the slow node

            while (fast != null && fast.next != null)
            {
                prev = slow;
                slow = slow.next;
                fast = fast.next.next;
            }

            prev.next = null;
        }


        public void displayContents()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + "->");
                current = current.next;
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            CustomLinkedList linkedList = new CustomLinkedList();
            Node firstNode = new Node(3);
            Node secondNode = new Node(4);
            Node thirdNode = new Node(5);
            Node fourthNode = new Node(6);

            linkedList.head = firstNode; //assigning the head to the first node
            firstNode.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = fourthNode;

            linkedList.displayContents();
            linkedList.deleteBackHalf();
            Console.WriteLine();
            linkedList.displayContents();
        }
    }
}