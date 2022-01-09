using System;
using System.Collections;

namespace ArraysAggregrateAndFilter
{
    class Program
    {
        static int[] FindEvenNums(int[] arr1, int[] arr2)
        {
            //use an arrayList to keep track of results
            ArrayList result = new ArrayList();
            
            //need two loops to go through each initial array and find evens
            foreach (int num in arr1)
            {
                if(num%2 == 0)
                {
                    result.Add(num);
                }
            }

            foreach (int num in arr2)
            {
                if (num%2 == 0)
                {
                    result.Add(num);
                }
            }

            //now need to convert the ARRAYLIST into an int array
            //need to cast since ToArray creates an object array but need an int array
            return (int[])result.ToArray(typeof(int));
        }

        static int[] FindOdds(int[] arr1, int[] arr2)
        {
            ArrayList resultOdd = new ArrayList();

            foreach (int num in arr1)
            {
                if (num % 2 == 1)
                {
                    resultOdd.Add(num);
                }
            }

            foreach (int num in arr2)
            {
                if (num % 2 == 1)
                {
                    resultOdd.Add(num);
                }
            }

            return (int[])resultOdd.ToArray(typeof(int));
        }

        static void Main(string[] args)
        {
            int[] arr1 = { -8, 2, 3, -9, 11, -20 };
            int[] arr2 = { 0, -2, -9, -39, 39, 10, 7 };

            int[] evenArr = FindEvenNums(arr1, arr2);
            int[] oddArr = FindOdds(arr1, arr2);
            Console.WriteLine("here is list of even numbers");
            Array.ForEach(evenArr,Console.WriteLine);

            Console.WriteLine("\n------------\nhere is list of odds");
            Array.ForEach(oddArr, Console.WriteLine);
        }
    }
}

/*
 NOTES:

aggregrating data combines two or more data sets
 
example: take two arrays, combine them, and return only the even numbers
 */
