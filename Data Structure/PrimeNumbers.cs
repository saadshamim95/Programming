using System;

namespace Data_Structure
{
    class PrimeNumbers
    {
        public void prime() {
            int[,] prime = new int[10,26];
            int k;
            for (int i = 0; i < 10; i++) {
                k = 0;
                for (int j = 0; j < 100; j++) {
                    int num = i * 100 + j;
                    bool flag = Utility.IsPrime(num);
                    if (flag) {
                        prime[i,k] = num;
                        k++;
                    }
                }
            }
            
            for (int i = 0; i < prime.GetLength(0); i++) {
                Console.Write("Prime Numbers between {0}-{1}: ", (i * 100), (i * 100 + 100));
                for (int j = 0; j < prime.GetLength(1); j++) {
                    if (prime[i, j] == 0)
                        break;
                    Console.Write(prime[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}