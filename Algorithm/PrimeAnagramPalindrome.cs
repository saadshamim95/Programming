using System;

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
                    primes[j++] = i;
                }
            }

            for (int i = 0; i < primes.Length; i++) {
                bool palindrome = Utility.IsPalindrome(primes[i]);
                if (palindrome) {
                    Console.WriteLine(primes[i] + " is Palindrome");
                }
            }

            for (int i = 0; i < primes.Length; i++) {
                for (int k = i + 1; k < primes.Length - 1; k++) {
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