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
            Stacks<char> stacks = new Stacks<char>();
            //string str = "(5+6)*(7+8)/(4+3)(5+6)*(7+8)/(4+3)";
            string str = "((5+(6-3)*((3/7)+3))/(11+13*((7/15)*(3+(15*5)))))";
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
            bool value = stacks.isEmpty();
            if (value)
                Console.WriteLine("Balanced Paranthesis!");
            else
                Console.WriteLine("Unbalanced Paranthesis!");
        }
    }
}
