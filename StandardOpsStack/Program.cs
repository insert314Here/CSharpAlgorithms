using System;
using System.Collections.Generic; //home for stack

namespace StandardOpsStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //use stack by first constructing
            Stack<string> stack = new Stack<string>();

            Console.WriteLine("Pushing 3 methods:");
            stack.Push("Main: 1st Push");
            stack.Push("ResponseBuilder: 2nd Push");
            stack.Push("ExternalServiceCalled: 3rd Push");
            DisplayStack(stack);

            stack.Pop();
            Console.WriteLine("\nPop function called");
            DisplayStack(stack);

            stack.Push("ParseExternalData: 4th Push");
            Console.WriteLine("----------\nPushing");
            DisplayStack(stack);
            Console.WriteLine("-----------\nPop 3 Times....");
            stack.Pop();
            DisplayStack(stack);
            stack.Pop();
            DisplayStack(stack);
            stack.Pop();
            DisplayStack(stack);

            //stack.Peek --> similar to queue
            // stack.TryPeek() --> see if stack is empty w/o raising error
            
            Console.WriteLine(stack.TryPeek(out string itemTryPeek));
            Console.WriteLine("-->imples stack is empty thru TryPeek Method");

        }

        static void DisplayStack(Stack<string> s)
        {
            Console.WriteLine("-----------\nCurrent Stack\n___________");
            foreach (string item in s)
            {
                
                Console.WriteLine(item);
            }
        }
    }
}

/*
 NOTES:

stacks are useful for algos where you need to keep track of state

series of ordered objects

Push: adds to the top of the stack

Pop: removes from the top of the stack

    add and remove from the TOP

LIFO policy: 
    the last item pushed will be the first item popped
 
    the first item pushed will be the last item popped

to retrieve a specific item, we must pop each item from the top to access

EX: runtime stack --> KEEPS TRACK OF THE EXECUTION OF THE PROGRAM AND PROCESSING NESTED FUNCTIONS --> also stores info about each sub-routine as they are used

    Main Function Called
    Some Builder Function used
    Then a util function might be called
 */
