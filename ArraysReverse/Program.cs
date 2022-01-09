using System;

namespace ArraysReverse
{
    class Program
    {
        static int[] Reverse(int[] input)
        {
            //create new array to hold reversed contents
            int[] reversed = new int [input.Length];

            for (int i=0; i < reversed.Length; i++)
            {
                            //takes the index at end of array and puts at begin of reversed
                reversed[i] = input[input.Length - i - 1];
            }

            return reversed;
        }

        //modifying the contents in the given array without creating new array as above
        static void ReverseInPlace(int[] input)
        {
            //since we are swapping elements, only need to go through half the array
            for(int i = 0; i<input.Length / 2; i++)
            {
                //the middle element will not need to move since it will be in the same index after reversal
                //swap index i (first index) with index(input.length -i - 1) *last index
                int temp = input[i]; //ensure value is not destroyed when swapping
                input[i] = input[input.Length - i - 1];

                input[input.Length - i - 1] = temp;
                
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Reverse array using new array");
            Array.ForEach(Reverse(arr), Console.WriteLine);

            Console.WriteLine("\n----------\nUsing swap method");
            ReverseInPlace(arr); //void method needs to be called first to swap
            Array.ForEach(arr, Console.WriteLine); //then display order

            Console.WriteLine("\n----------\nUsing swap method twice gets original");
            ReverseInPlace(arr);
            
            Array.ForEach(arr, Console.WriteLine);
        }
    }
}
