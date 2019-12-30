using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class AnagramDetection
    {
        public void anagram() {
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine();
            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine();
            bool result = Utility.IsAnagrams(str1, str2);
            //Console.WriteLine(result);
            if (result)
                Console.WriteLine(str1 + " and " + str2 + " are anagrams!");
            else
                Console.WriteLine("Strings are not anagrams!");
        }
    }
}
