using System;


namespace DeleteKthNode_LinkedList_Challenge
{
    class CustomLinkedList
    {
        Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d) { data = d; }
        }

        public void DeleteKNodeEnd(int k)
        {
            if (head == null || k == 0)
            {
                //nothing to delete in this case so...
                return;
            }

            //node trackers/pointers
            // EX: [a,b,c,d]
            // EX: k=2
            Node first = head; // EX: a
            Node second = head;// EX: a

            for (int i =0;i<k;i++)//kth node from head of the list
            {
                second = second.next; //if this is null we are in last element of list
                if (second == null) //k must be greater than our equal to # of items
                {
                    if (i == k - 1)
                    {
                        //checks if k is equal to length of list
                        head = head.next; //deletes first element
                    }
                    return;
                }
            }
            
            //now second node is pointing to the kth element from the head of the list
            //we want to delete the node that is the kth node from the end of the list

            //to find this element we increment the 1st and 2nd pointers until the second pointer reaches last element --> second.next == null

            //EX: second = c
            while (second.next != null)
            {
                first = first.next;
                second = second.next;
                //when the second node reaches the end of the list, the first node will be at the kth element --> what we want to delete
            }
            //EX: first = b, second = d
            //EX: [a,b,c,d] if k=2 we want to delete 2nd node from end -->c
            first.next = first.next.next;
        }

        public void displayContents()
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
            CustomLinkedList linkedList = new CustomLinkedList();
            Node firstNode = new Node(3);
            Node secondNode = new Node(4);
            Node thirdNode = new Node(5);
            Node fourthNode = new Node(6);

            linkedList.head = firstNode;
            firstNode.next = secondNode;
            secondNode.next = thirdNode;
            thirdNode.next = fourthNode;

            Console.WriteLine("Which element to delete?");
            linkedList.displayContents();
            Console.WriteLine();
            int delete = Convert.ToInt32(Console.ReadLine());
            linkedList.DeleteKNodeEnd(delete);
            Console.WriteLine($"Deleting element {delete} from end of list...\n");
            Console.WriteLine("Updated List");
            linkedList.displayContents();
            Console.WriteLine();
                
        }
    }
}


/*
 Original:
4->6->10->3->11->null
K=1

The first node from the end of the list is 11

Final:
4->6->10->3->null
 
 
 */