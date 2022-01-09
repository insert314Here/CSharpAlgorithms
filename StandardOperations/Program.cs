using System;
using System.Collections.Generic;
using System.Linq;

namespace StandardOperationsQueue
{
    internal class Program : DisplayQ
    {
        static void Main(string[] args)
        {
            //queue class is generic
            Queue<int> queue = new Queue<int>();

            //have to instantiate class in order to access methods in the class
            DisplayQ d = new DisplayQ();
            //adding elements
            queue.Enqueue(1); //first
            queue.Enqueue(8);
            queue.Enqueue(20);
            queue.Enqueue(23); //last

            d.UpdateScreen(queue);
            

            int removedItem = queue.Dequeue(); //returns the item removed
            Console.WriteLine($"\nRemoved: {removedItem}");

            d.UpdateScreen(queue);

            
            Console.WriteLine($"\nRemoved: {queue.Dequeue()}");

            d.UpdateScreen(queue);
            
            Console.WriteLine($"\n\nUsing Peek method to view... {queue.Peek()}\nDoes not remove value");
            
            d.UpdateScreen(queue);

            //TryDeque will attempt to DeQ and return either true/false

            Console.WriteLine("\n-----------------\nUsing TryDeque Method to display queue");
            //need to pass in a variable to save the dequeued item
            Console.WriteLine("\nExecuting TryDequeue Method...");
            while (queue.TryDequeue(out int current))
            {
                //if method can deque an item --> saved to current
                Console.WriteLine(current);
            }

            Console.WriteLine($"\nDoes TryDequeue remove items or stay boolean???\n-----");
            
            d.UpdateScreen(queue);
            if (queue.Count() == 0)
            {
                Console.WriteLine("Queue is empty...");
            }
        }

        
    }
}

/*
 NOTES:

a queue contains the elements in the order they were added

elements are inserted at the end and removed from the front
    can only remove from front, can only add to end

indecies DNE for queues

FIFO policy
enqueue: adds an item to the back
dequeue: removes an item from the front
peek: access the item at the front of the queue

 
 */