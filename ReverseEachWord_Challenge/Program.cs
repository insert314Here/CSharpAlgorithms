using System;
using System.Text;

namespace ReverseEachWord_Challenge
{
    internal class Program
    {
        static String ReverseEachWord(String s)
        {
            //check for nulls
            if (String.IsNullOrEmpty(s))
            {
                return s;
            }

            StringBuilder reverse = new StringBuilder();

            for (int i = s.Length - 1; i>= 0; i--)
            {
                reverse.Append(s[i]);
            }

            return reverse.ToString();
        }


        static void Main(string[] args)
        {
            Console.WriteLine(ReverseEachWord("Taylor is a great worker"));
            Console.WriteLine(ReverseEachWord(null));
            Console.WriteLine(ReverseEachWord("racer racecar madam"));
            Console.WriteLine(ReverseEachWord("what can I do today"));
            Console.WriteLine(ReverseEachWord(" "));
        }
    }
}

/*
 CHALLENGE DETAILS:
create algo to reverse each word in a sentence.

INPUT: string

OUTPUT: new string with each word reversed

ASSUME: no puncts in the string, only space seperated

Casing should remain same

 */
