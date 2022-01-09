using System;
using System.Collections.Generic;

namespace NextGreaterElementStack
{
    internal class Program
    {
        static void PrintNextGreaterElement(int[] arr)
        {
            //array must have items to print
            if(arr.Length <= 0)
            {
                Console.WriteLine("Empty List");
                return;
            }

            Stack<int> stack = new Stack<int>();
            //push first element --> i=1 below
            stack.Push(arr[0]);

            for (int i = 1; i < arr.Length; i++)
            {
                int next = arr[i];
                if (stack.Count > 0)
                {
                    //if the stack has items, pop off the top and check if greater than other
                    int popped = stack.Pop();

                    while (popped < next)
                    {
                        Console.WriteLine($"{popped} --> {next}");
                        if (stack.Count == 0)
                        {
                            break; //get out of loop once stack is empty
                        }
                        popped = stack.Pop(); //increments
                    }

                    if(popped > next)
                    {
                        stack.Push(popped);
                    }
                }
                stack.Push(next);
            }

            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop() + "-->" + -1);
            }

        }

        static void Main(string[] args)
        {
            int[] arr = new int[] { 15, 8, 4, 10 };
            int[] arr2 = new int[] { 2 };
            int[] arr3 = new int[] { 2, 3 };
            int[] arr4 = new int[] { };

            PrintNextGreaterElement(arr);
            PrintNextGreaterElement(arr2);
            PrintNextGreaterElement(arr3);
            PrintNextGreaterElement(arr4);
        }
    }
}

/* EX: {15, 8, 4, 10}
 * OUTPUT: 15 --> -1 
 *      -1 return value indicates nothing found
 * PATTERN: continue to look to the right of the array for next greater element
 *
 */


