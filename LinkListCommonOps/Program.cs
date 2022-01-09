using System;
using System.Collections.Generic;

namespace LinkListCommonOps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> listy = new LinkedList<string>();
            //addlast
            //addfirst
            listy.AddLast("Sarah");
            listy.AddLast("Polly");
            listy.AddLast("Rebecca");
            listy.AddLast("Jess");
            listy.AddLast("Jackie");

            Console.WriteLine("list contains Polly");
            Console.WriteLine(listy.Contains("Polly"));
            Console.WriteLine("\n-----\nCount method id's how many nodes");
            Console.WriteLine(listy.Count);

            Console.WriteLine("\n-----\nremoving first node, Sarah");
            listy.RemoveFirst();

            foreach(string item in listy)
            {
                Console.Write(item + "->");
            }
            Console.WriteLine();


        }
    }
}

/*
 NOTES:

linked lists do not have indices, they are linked by pointers

each element is a node, containing a piece of data and a reference to the next element
 
first node is called the HEAD
last node is called the TAIL

the size of a linked list can vary over time
    contrary to arrays where they have a set length at time of creation
        can create new array to accomodate larger/smaller sets

generic lists can hold multiple types of data including custom object data
    arrays are of a single data type

 */
