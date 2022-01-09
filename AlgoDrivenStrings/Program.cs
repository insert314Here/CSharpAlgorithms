using System;
using System.Text;

//create a string based on input data
namespace AlgoDrivenStrings
{
    internal class Program
    {
        //reverse a string manually
        
        static String Reverse(String input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            //library
            StringBuilder reversed = new StringBuilder(input.Length);

            //starting at last index and moving towards 0 index (start)
            for(int i = input.Length-1; i>=0; i--)
            {
                //using string builder variable above takes the last index of input and places in new string 'reversed'

                reversed.Append(input[i]);
            }

            //need ToString method since we are using StringBuilder
            return reversed.ToString();
        }

        //use method to reverse string
        static String Reverse2(String input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            char[] arr = input.ToCharArray();

            Array.Reverse(arr); //only reverses, does not create new array

            return new String(arr);
            
        }


        static void Main(string[] args)
        {
            Console.WriteLine("type a word to reverse");
            string word = Console.ReadLine();
            Console.WriteLine($"We are going to reverse {word}\n{Reverse(word)}");

            Console.WriteLine("\n------\ntype a word to reverse using array method");
            string word2 = Console.ReadLine();
            Console.WriteLine($"We are going to reverse {word}\n{Reverse2(word)}");
        }
    }
}

/*
 NOTES:

Strings are immutable so they can not be changed once created

When StringBuilder is modified it does not create a new string --> saves mem --> more efficient than normal string
 
 */
