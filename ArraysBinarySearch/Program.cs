using System;

namespace ArraysBinarySearch
{
    internal class Program
    {
        static Boolean BinarySearch(int[] inputeArray, int item)
        {
            // set constraints for the array
            int min = 0;
            int max = inputeArray.Length - 1;

            while (min <= max)
            {
                int midPt = (min + max) / 2;
                if(item == inputeArray[midPt])
                {
                    return true;
                }
                else if(item < inputeArray[midPt])
                {
                    //if the item is less than the midpoint of the array
                    max = midPt - 1; //new max established to half the array
                }
                else
                {
                    min = midPt+1;
                }
            }

            return false; //if item does not exist
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("searching for 5 in pre sorted array, ascending");
            Console.WriteLine(BinarySearch(arr,5));

            Console.WriteLine("\nUsing built in Binary Search method\nsearching for 5\nreturns the index value of where the item is located");
            Console.WriteLine(Array.BinarySearch(arr, 5));
        }
    }
}

/*
 NOTES:

binary search halves the number of elements it has to search through

array needs to sorted first

for unsorted arrays, time complexity may vary and a linear search may be more efficient depending on size of array --> time is needed to sort array

 
 */
