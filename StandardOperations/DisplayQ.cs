using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandardOperationsQueue
{
    public class DisplayQ
    {
        ////Queue<int> queue = new Queue<int>();

        public void UpdateScreen(Queue<int> q)
        {
            
            
            Console.WriteLine("\nCurrent Queue:");
            foreach (int s in q)
            {
                Console.Write(s);
                Console.Write(" ");

            }
            
        }
    }
}
