using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_And_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);

            foreach (int item in queue)
            {
                Console.WriteLine("Pushing the Elements in Queue.");
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------------------------------\n");
        }
    }
}
