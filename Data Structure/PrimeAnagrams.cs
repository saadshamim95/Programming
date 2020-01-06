using System;

namespace Data_Structure
{
    class PrimeAnagrams
    {
        /// <summary>
        /// Anagrams this instance.
        /// </summary>
        public void Anagram() {
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
                    if (anagram) {
                        int l = j;
                        flag1 = false;
                        flag2 = false;
                        while (l > 0) {
                            if (anagramArray[l] == primes[i])
                                flag1 = true;
                            if (anagramArray[l] == primes[k])
                                flag2 = true;
                            if(flag1 && flag2)
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

            int[][] array = new int[2][];
            array[0] = new int[108];
            array[1] = new int[61];
            int m = 1;
            int n = 0;
            for (int i = 0; i < primes.Length - 1; i++) {
                if (primes[i] == anagramArray[m]) {
                    array[0][m] = primes[i];
                    m++;
                }
                else {
                    array[1][n] = primes[i];
                    n++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Prime numbers that are Anagrams: ");
            for (int i = 1; i < array[0].Length; i++) {
                Console.Write(array[0][i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Prime numbers that are not Anagrams: ");
            for (int i = 0; i < array[1].Length; i++)
            {
                if (array[1][i] == 0)
                    break;
                Console.Write(array[1][i] + " ");
            }                
        }
    }
}