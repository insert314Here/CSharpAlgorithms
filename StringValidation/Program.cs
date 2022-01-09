using System;
using System.Linq;

namespace StringValidation
{
    internal class Program
    {
        static bool IsUpper(string s)
        {
            return s.All(char.IsUpper);
        }

        static bool IsLower(string s)
        {
            return s.All(char.IsLower);
        }

        static bool IsPassComplex(string s)
        {
            return s.Any(char.IsUpper) && s.Any(char.IsLower) && s.Any(char.IsDigit);
        }

        static void Main(string[] args)
        {
            string allLow = "hello";
            string allUp = "HELLO";

            Console.WriteLine($"hello is all upper?  T/F: {IsUpper(allLow)}");
            Console.WriteLine($"HELLO is all upper? T/F: {IsUpper(allUp)}");
            Console.WriteLine($"hello is all lower?  T/F: {IsLower(allLow)}");
            Console.WriteLine($"HELLO is all lower? T/F: {IsLower(allUp)}");

            Console.WriteLine($"Hello79 is a complex password T/F: {IsPassComplex("Hello79")}");
            Console.WriteLine($"hello79 is a complex password T/F: {IsPassComplex("hello79")}");

        }
    }
}
