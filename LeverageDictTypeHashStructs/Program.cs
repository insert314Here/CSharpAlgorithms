using System;
using System.Collections.Generic;

namespace LeverageDictTypeHashStructs
{
    internal class Program
    {
        static void DisplayFreq(int[] arr)
        {
            Dictionary<int, int> freqDict = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (freqDict.ContainsKey(arr[i]))
                {
                    freqDict[arr[i]]++; //incrementing value
                }
                else
                {
                    //put key in dictionary and give value 1
                    freqDict[arr[i]] = 1;
                }
            }

            foreach (KeyValuePair<int,int> x in freqDict)
            {
                Console.WriteLine($"Key:{x.Key} Occurs: {x.Value} time(s)");
            }
        }

        static void Main(string[] args)
        {
            DisplayFreq(new int[] { 3, 0, 4, 5, 6, 4, 2, 1, 3, 2, 4, 5, 6, 7, 8, 9, 8, 8, 7, 6, 6, 5 });
        }
    }
}
