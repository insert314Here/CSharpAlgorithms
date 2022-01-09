using System;

namespace ArraysLinearSearch
{
    internal class Program
    {
        static int? LinearSearch(int[] arr, int n)
        {//aka Sequential search
            foreach(int i in arr)
            {
                if (n == i)
                {
                    return n;
                }
            }

            //adding ? to return type allows null to be a possibility
            return null;
        }

        static Boolean LinearSearchBool(int[] arr, int n)
        {//aka Sequential search
            foreach (int i in arr)
            {
                if (n == i)
                {
                    return true;
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 4, 2, 7, 3};

            Console.WriteLine("what number do you want to search for in the following array?\nIf youre number is present, you will see it displayed again");         
            Console.WriteLine();
            int searchInt = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine(LinearSearch(arr, searchInt));

            Console.WriteLine("\n-------------\nUsing LinearSearchBool");
            int searchInt2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(LinearSearchBool(arr, searchInt2));

            Console.WriteLine("\n------------\nUsing Array.Find Method, looks for 3, there are two 3's in the array");
            //Find only takes the first item found
            int item = Array.Find(arr, element => element == 3);
            Console.WriteLine(item);
            Console.WriteLine("\n------------\nUsing Array.FindALL Method, looks for all elements greater than 5");
            int[] items = Array.FindAll(arr, element => element >= 5);

            Array.ForEach(items, Console.WriteLine);
        }
    }
}
