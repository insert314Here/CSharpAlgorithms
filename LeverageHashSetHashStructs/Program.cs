using System.Collections.Generic;
using System;

namespace LeverageHashSetHashStructs
{
    internal class Program
    {
        static List<int> FindMissingElements(int[] first, int[] second)
        {
            List<int> missingElements = new List<int>();
            HashSet<int> secondArrayItems = new HashSet<int>();
            //recall hashSets use unique values
            foreach (int item in second)
            {
                secondArrayItems.Add(item);
                //adding each item in the second array to hashSet
            }
            //now can cross check
            foreach (int item in first)
            {
                if (!secondArrayItems.Contains(item))
                {
                    //if item in first is not in secondArray, add to missing elements
                    missingElements.Add(item);
                }
            }

            return missingElements;

        }
        static void Main(string[] args)
        {
            FindMissingElements(new int[] { 1, 2, 3, 4 }, new int[] { 2, 4 }).ForEach(Console.WriteLine);
        }
    }
}

/*  USE CASE:
 *      find items present in one array but not the other
 *      {3,2,8,4,5}
 *      {5,7,3,0,2}
 *      i.e. What elements are members of 1st array but not second
 *      
 */