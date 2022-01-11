using System.Collections.Generic;
using System;

namespace practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 4,1,9,4,3,5, 1, 9, 4, 3,5 };
            //creating a new list 
            List<int> uniqueList = new List<int>();
            foreach (int num in a)
            {
                if (!uniqueList.Contains(num))
                {
                    uniqueList.Add(num);
                }
                else
                {
                    uniqueList.Remove(num);
                }
            }
            Console.WriteLine(uniqueList[0]);
            Console.WriteLine(uniqueList[1]);
            //Console.WriteLine(uniqueList[2]);
            //Console.WriteLine(uniqueList[3]);
            //Console.WriteLine(uniqueList[4]);
            //Console.WriteLine(uniqueList[5]);

        }

        

    }
}

