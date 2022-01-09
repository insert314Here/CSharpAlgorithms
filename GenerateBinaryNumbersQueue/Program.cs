using System;
using System.Collections.Generic;

namespace GenerateBinaryNumbersQueue
{
    internal class Program
    {
        static void PrintBinary(int n)
        {
            if (n <= 0)
            {
                return;
            }
            Queue<int> q = new Queue<int>();
            
            q.Enqueue(1);
            
            
            for(int i = 0; i < n; i++)
            {
                //take item off the top of q and display
                int current = q.Dequeue();
                Console.WriteLine($"{i+1} binary is: {current}");
                //append a zero to add next binary --> *10
                q.Enqueue(current * 10);// 1 --> 10
                //append a 1
                q.Enqueue(current * 10 + 1); // 1 --> 11
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.Write("How many Binary Numbers would you like to print?");
            int biCount = Convert.ToInt32(Console.ReadLine());
            PrintBinary(biCount);
        }
    }
}
/*
 Challenge: print out the first N binary numbers in numerical order

if N=5 --> 1,2,3,4,5 disaplyed as binary
1
10
11
100
101
 
 */