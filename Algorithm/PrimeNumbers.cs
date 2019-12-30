using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class PrimeNumbers
    {
        public void prime() {
            Console.WriteLine("Prime Numbers between 0 & 1000 are: ");
            for (int i = 0; i <= 1000; i++) {
                bool result = Utility.IsPrime(i);
                if (result == true)
                    Console.Write(i + " ");
            }
        }
    }
}
