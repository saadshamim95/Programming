using System;

namespace Functional
{
    class Factors
    {
        /// <summary>
        /// Prints the factors.
        /// </summary>
        public void printFactors() {
            int num = 0;
            while (num < 2) {
                Console.Write("Enter the val on N: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Prime Factors: ");
            for (int i = 2; i * i <= num; i++) {
                while (num % i == 0) {
                    Console.Write(i + " ");
                    num = num / i;
                }
                //Console.WriteLine("For Loop");
            }
            if (num > 1)
                Console.Write(num); 
        }
    }
}