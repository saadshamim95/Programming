﻿using System;

namespace Data_Structure
{
    class PrimeAnagramUsingStack
    {
        /// <summary>
        /// Reverses the printing.
        /// </summary>
        public void reversePrinting() {
            int[] primes = new int[169];
            int j = 0;
            for (int i = 0; i < 1000; i++)
            {
                bool prime = Utility.IsPrime(i);
                if (prime)
                    primes[j++] = i;
            }

            int[] anagramArray = new int[108];
            j = 0;
            for (int i = 0; i < primes.Length; i++)
            {
                for (int k = i + 1; k < primes.Length - 1; k++)
                {
                    string str1 = Convert.ToString(primes[i]);
                    string str2 = Convert.ToString(primes[k]);
                    bool anagram = Utility.IsAnagrams(str1, str2);
                    bool flag1;
                    bool flag2;
                    if (anagram)
                    {
                        int l = j;
                        flag1 = false;
                        flag2 = false;
                        while (l > 0)
                        {
                            if (anagramArray[l] == primes[i])
                                flag1 = true;
                            if (anagramArray[l] == primes[k])
                                flag2 = true;
                            if (flag1 && flag2)
                                break;
                            l--;
                        }
                        if (!flag1 && !flag2)
                        {
                            anagramArray[j++] = primes[i];
                            anagramArray[j++] = primes[k];
                        }
                        else if (flag1 && !flag2)
                            anagramArray[j++] = primes[k];
                        else if (!flag1 && flag2)
                            anagramArray[j++] = primes[i];
                    }
                }
            }
            Array.Sort(anagramArray);

            StackLinkedList<int> stack = new StackLinkedList<int>();
            for (int i = 0; i < anagramArray.Length; i++)
                stack.push(anagramArray[i]);

            Console.Write("Printing Stack: ");
            Console.WriteLine();

            for (int i = 0; i < anagramArray.Length - 1; i++)
            {
                Console.Write(stack.pop() + " ");
            }
        }
    }
}