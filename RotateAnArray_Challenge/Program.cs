using System;

namespace RotateAnArray_Challenge
{
    internal class Program
    {
        static void RotateLeft(int[] input)
        {

            //first case exception since there is not a -1 index
            int temp = input[0];

            for (int i = 0; i < input.Length - 1; i++)
            {
                input[i] = input[i + 1];
            }

            input[input.Length - 1] = temp;
        }

        static void RotateArrayRight(int[] input)
        {
            int temp = input[input.Length - 1];

            for (int i = input.Length-1; i > 0; i--)
            {
                input[i] = input[i - 1];
            }

            input[0] = temp;
        }


        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("original array");
            Array.ForEach(arr, Console.WriteLine);
            RotateLeft(arr);
            Console.WriteLine("\n----------\nleft rotate");
            Array.ForEach(arr, Console.WriteLine);
            RotateArrayRight(arr);
            RotateArrayRight(arr);
            Console.WriteLine("\n----------\nright rotate");
            Array.ForEach(arr, Console.WriteLine);
        }
    }
}

/*
 Details:
rotate the contents of an array to the left by one space
BONUS: rotate to the right

rotate in place DO NOT create a new array

Input {1,2,3,4,5,6}
Output {2,3,4,5,6,1}
 
 */
