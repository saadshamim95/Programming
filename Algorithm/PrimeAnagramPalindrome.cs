using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class PrimeAnagramPalindrome
    {
        /// <summary>
        /// Checks for prime anagram palindrome.
        /// </summary>
        public void checkForPrimeAnagramPalindrome() {
            int[] primes = new int[168];
            int j = 0;
            for (int i = 0; i < 1000; i++) {
                bool prime = Utility.IsPrime(i);
                if (prime) {
                    primes[j] = i;
                    j++;
                }
            }

            /*for (int i = 0; i < primes.Length; i++) {
                Console.Write(primes[i] + " ");
            }*/

            //Console.Write(j);
            for (int i = 0; i < primes.Length; i++) {
                bool palindrome = Utility.IsPalindrome(primes[i]);
                if (palindrome) {
                    Console.WriteLine(primes[i] + " is Palindrome");
                }
            }

            for (int i = 0; i < primes.Length - 1; i++) {
                for (int k = i + 1; k < primes.Length - 2; k++) {
                    string str1 = Convert.ToString(primes[i]);
                    string str2 = Convert.ToString(primes[k]);
                    bool anagram = Utility.IsAnagrams(str1, str2);
                    if (anagram)
                        Console.WriteLine(primes[i] + " & " + primes[k] + " are anagrams!");
                }
            }
        }
    }
}
