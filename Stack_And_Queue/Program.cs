using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_And_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);

            foreach (int item in stack)
            {
                Console.WriteLine("Pushing the Elements in Stack");
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------\n");
        }
    }
}
