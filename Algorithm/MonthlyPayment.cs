using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class MonthlyPayment
    {
        /// <summary>
        /// Payments this instance.
        /// </summary>
        public void payment() {
            Console.Write("Enter the value of Principal Amount(P): ");
            int P = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of Years(Y): ");
            double Y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the value of Rate(R): ");
            double R = Convert.ToDouble(Console.ReadLine());
            double payment = Utility.monthlyPayment(P, Y, R);
            Console.WriteLine("Monthly Payment: Rs.{0:0.00}", payment);
        }
    }
}
