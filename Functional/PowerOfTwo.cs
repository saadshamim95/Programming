using System;

namespace Functional
{
    class PowerOfTwo
    {
        public void printPowerOfTwo() {
            int num=32;
            while (!(num >= 0 && num < 31)) {
                Console.WriteLine("Enter the value between 0 & 31:");
                num = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i <= num; i++) {
                //Console.WriteLine("Here");
                Console.WriteLine("2 to the power "+i+": "+Math.Pow(2, i));
            }
        }
    }
}
