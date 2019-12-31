using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    class PalindromeChecker
    {
        public void check() {
            string str = "saad";
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
