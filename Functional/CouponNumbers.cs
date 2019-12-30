using System;

namespace Functional
{
    class CouponNumbers
    {
        /// <summary>
        /// Coupons the code.
        /// </summary>
        public void CouponCode() {
            Console.Write("Enter the number of Coupons: ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool[] used = new bool[number];
            int number_of_times = 0;
            for (int i = 0; i < number; i++)
                used[i] = false;
            int count = 0;
            while (count != number) {
                Random random = new Random();
                int position = random.Next(number) % number;
                //Console.WriteLine("Position: " + position);
                if (!used[position]) {
                    used[position] = true;
                    count++;
                }
                number_of_times++;
            }
            Console.WriteLine("Total number of times to have all Coupon Code generated: " + number_of_times);
        }
    }
}