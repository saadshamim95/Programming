using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class SquareRoot
    {
        /// <summary>
        /// Calculates the square root.
        /// </summary>
        public void calculateSquareRoot() {
            int num = -1;
            while (!(num >= 0)) {
                Console.Write("Enter the number whose Square Root you want: ");
                num = Convert.ToInt32(Console.ReadLine());
            }
            double root = Utility.sqrt(num);
            Console.WriteLine("Square Root of {0} is {1:0.00}", num, root);
        }
    }
}
