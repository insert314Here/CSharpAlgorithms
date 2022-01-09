using System;

namespace NormalizeString
{
    internal class Program
    {
        static string NormalizeString(string input)
        {
            return input.ToLower().Trim().Replace(",", "");

            //string lowerCase = input.ToLower();
            //string lowerTrimmed = lowerCase.Trim();
            //return lowerTrimmed.Replace(",", "");
        }
        static void Main(string[] args)
        {
            string norm1 = " Hello there, BUDdy";
            Console.WriteLine($"Normalizing {norm1}:\n Process Complete: {NormalizeString(norm1)}");
        }
    }
}
