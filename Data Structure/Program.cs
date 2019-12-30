using System;

namespace Data_Structure
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Stack<char> stacks = new Stack<char>();
            string str = "(5+6)*(7+8)/(4+3)(5+6)*(7+8)/(4+3)";
            //string str = "((5+(6-3)*((3/7)+3))/(11+13*((7/15)*(3+(15*5)))))";
            char[] charArray = str.ToCharArray();
            for (int i = 0; i < charArray.Length; i++) {
                if (charArray[i] == '(')
                    stacks.push('(');
                else if (charArray[i] == ')')
                    stacks.pop();
                Console.Write("Stack: ");
                stacks.Print();
                Console.WriteLine();
            }
            if (stacks.isEmpty())
                Console.WriteLine("Balanced Paranthesis!");
            else
                Console.WriteLine("Unbalanced Paranthesis!");

            Queue<int> queue = new Queue<int>();
            queue.enqueue(2);
            queue.enqueue(3);
            queue.enqueue(4);
            Console.Write("Queue: ");
            queue.Print();
            Console.WriteLine();
            queue.dequeue();
            queue.enqueue(5);
            Console.Write("Queue: ");
            queue.Print();
            Console.WriteLine();
            queue.dequeue();
            queue.dequeue();
            Console.Write("Queue: ");
            queue.Print();
            Console.WriteLine();
        }
    }
}
