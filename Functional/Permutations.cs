using System;

namespace Functional
{
    class Permutations
    {
        public void permutation() {
            string str = "abcd";
            int start = 0;
            int end = str.Length - 1;
            permute(str, start, end);
        }

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
