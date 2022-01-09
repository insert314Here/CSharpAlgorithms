using System;

namespace LinkListAlgos
{
    class CustomLinkedList
    {

        Node head; //creating first node in list

        public class Node
        {
            public int data;
            public Node next;

            public Node(int d) { data = d; }
        }

        public void DeleteBackHalf()
        {
            if (head == null || head.next == null)
            {
                head = null;
            }

            //need a variable to keep track of where we are in the loop
            Node slowPoint = head;
            Node fastPoint = head;
            Node prev = null;

            while (fastPoint != null && fastPoint.next != null)
            {
                prev = slowPoint;
                slowPoint = slowPoint.next;
                fastPoint = fastPoint.next.next;
            }

            prev.next = null;
        }

        public void DisplayContents()
        {
            Node current = head;

            while (current != null)
            {
                Console.Write(current.data + "->");
                current = current.next;
            }
        }

        static void Main(string[] args)
        {
            //initial constructor so can use class attributes
            CustomLinkedList linkedList = new CustomLinkedList();
            //Node types allow usage of next
            Node firstNode = new Node(3);
            Node secondNode = new Node(4);
            Node thirdNode = new Node(5);
            Node fourthNode = new Node(6);

            linkedList.head = firstNode;
            //use pointers to add more items to linked list
            firstNode.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = fourthNode;

            Console.WriteLine("display list of contents");
            linkedList.DisplayContents();
            Console.WriteLine("\ndeleting back half......");
            linkedList.DeleteBackHalf();
            Console.WriteLine("\ncontents after back half delete");
            linkedList.DisplayContents();
        }
    }
}
