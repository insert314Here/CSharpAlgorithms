using System;
using System.Collections.Generic;

namespace MatchingParenthesesStack_Challenge
{
    internal class Program
    {
        static bool HasMatchParenths(string s)
        {
            Stack<char> stack = new Stack<char>();

            //iterate through string to find matching
            for (int i = 0; i < s.Length; i++)
            {
                char current = s[i];

                if (current == '(')
                {
                    stack.Push(current);
                    continue;  //passes control back to the next iteration of loop
                }
                if (current == ')')
                {
                    if (stack.Count > 0) 
                        //will be greater during first run if parentheses exists
                        //sub-runs will push/pop if counterpart found
                    {
                        //cant pop the stack if there are no items in stack
                        stack.Pop();
                    }
                    else
                    {
                        return false; //returns false if the stack is empty
                    }
                    
                }
            }


            //if by end of execution, will be false if there are more opening VS closing
            return stack.Count == 0; //implies and equal amount of opens/closes
        }

        static void Main(string[] args)
        {
            Console.WriteLine(HasMatchParenths("((hello()))"));
            Console.WriteLine(HasMatchParenths("()(hello())"));
            Console.WriteLine(HasMatchParenths("((hello))"));
            Console.WriteLine(HasMatchParenths("(hello)"));

            Console.WriteLine();

            Console.WriteLine(HasMatchParenths("(hello("));
            Console.WriteLine(HasMatchParenths(")hello)"));
            Console.WriteLine(HasMatchParenths(")hello("));
            Console.WriteLine(HasMatchParenths("hello(("));
            Console.WriteLine(HasMatchParenths("(hello"));
            Console.WriteLine(HasMatchParenths("((hello)"));
        }
    }
}

/*CHALLENGE: find mathcin parenths
 * 
 * MATCHING EX:
 *      ((hello())) --> appropriate closures
 * 
 * NOT EX:
 *      (hello(
 */
