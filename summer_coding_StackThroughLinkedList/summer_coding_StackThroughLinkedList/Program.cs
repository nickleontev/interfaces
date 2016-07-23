using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace summer_coding_StackThroughLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            StackThroughLinkedList<int> stack = new StackThroughLinkedList<int>();

            stack.Push(33);
            stack.Push(11);

            Console.WriteLine(stack.Count);

            stack.Pop();
            
            Console.WriteLine(stack.Peek());
            Console.ReadKey();
        }
    }
}
