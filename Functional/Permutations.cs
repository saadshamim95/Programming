using System;

namespace Functional
{
    class Permutations
    {
        /// <summary>
        /// Permutations this instance.
        /// </summary>
        public void permutation() {
            string str = "abcd";
            int start = 0;
            int end = str.Length - 1;
            permute(str, start, end);
        }

        /// <summary>
        /// Permutes the specified string.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        public void permute(string str, int start, int end) {
            if (start == end)
                Console.WriteLine(str);
            else {
                
                for (int i = start; i <= end; i++) {
                    str = swap(str, start, i);
                    permute(str, start + 1, end);
                    str = swap(str, start, i);
                }
            }
        }

        /// <summary>
        /// Swaps the specified string.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="i">The i.</param>
        /// <param name="j">The j.</param>
        /// <returns></returns>
        public String swap(string str, int i, int j) { 
            char temp;
            char[] charArray = str.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string perstr = new string(charArray);
            //Console.WriteLine(charArray);
            return perstr;
        }
    }
}