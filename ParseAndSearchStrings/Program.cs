using System;
using System.Linq;

namespace ParseAndSearchStrings
{
    internal class Program
    {

        static void ParseContents(string s)
        {
            Console.WriteLine("Option 1: foreach Loop");

            foreach (char c in s)
            {
                Console.Write(c);
            }
            Console.WriteLine("");
            Console.WriteLine("\nOption 2: for loop");
            for (int i = 0; i <s.Length; i++)
            {
                char c = s[i];
                Console.Write(c);
            }
            Console.WriteLine("");
        }

        static bool IsAtEvenIndex(string s, char item)
        {
            //first want to check if a given string is null

            if (string.IsNullOrEmpty(s))
            {
                return false;
            }

            for (int i = 0; i<s.Length / 2 + 1; i=i+2)
            //+2 allows to iterate through even indices
            //we dont want to access a character at an ivalid location -> / 2 +1
            {
                if(s[i] == item)
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("just with contain method");
            Console.WriteLine("Hello World!".Contains("ll"));

            Console.WriteLine("\nWith ToLower method");
            Console.WriteLine("Hello World!".ToLower().Contains("ll"));

            Console.WriteLine("\nUsing ParseContents Method:");
            ParseContents("Hello World");

            Console.WriteLine("\n--------------------\nUsing IsAtEvenIndex Method:");
            string evenIndexString = "HeLLo";

            Console.WriteLine($"is L at an even index in {evenIndexString}\n{IsAtEvenIndex(evenIndexString,'L')}\n");

            Console.WriteLine($"is e at an even index in {evenIndexString}\n{IsAtEvenIndex(evenIndexString, 'e')}\n");

            Console.WriteLine($"is H at an even index in {evenIndexString}\n{IsAtEvenIndex(evenIndexString, 'H')}\n");

            Console.WriteLine($"no input parameter for this one\n{IsAtEvenIndex("", 'H')}\n");

            Console.WriteLine($"null parameter given\n{IsAtEvenIndex(null, 'H')}\n");
        }
    }
}
