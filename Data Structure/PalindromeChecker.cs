using System;

namespace Data_Structure
{
    class PalindromeChecker
    {
        /// <summary>
        /// Checks this instance.
        /// </summary>
        public void Check() {
            //string str = "saad";
            Console.Write("Enter the string: ");
            string str = Console.ReadLine();
            str = str.ToLower();
            char[] array = str.ToCharArray();
            Deque<char> deque = new Deque<char>();
            for (int i = 0; i < array.Length; i++)
                deque.addFront(array[i]);
            string str2 = new string(deque.getArray()).Substring(0, str.Length);
            //Console.WriteLine(str2);
            if (str == str2)
                Console.WriteLine(str + " is Palindrome");
            else
                Console.WriteLine(str + " is not a Palindrome");
        }
    }
}