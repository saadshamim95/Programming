using System;

namespace Functional
{
    class HarmonicNumber
    {
        /// <summary>
        /// Prints the harmonic number.
        /// </summary>
        public void printHarmonicNumber() {
            int num = 0;
            while (num < 1) {
                Console.WriteLine("Enter the value of N: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            double sum = 0;
            for (int i = 1; i <= num; i++) {
                sum = sum + (1.0 / i);
                //Console.WriteLine("Sum = " + sum);
            }
            Console.WriteLine("Nth Harmonic Value = " + sum);
        }
    }
}