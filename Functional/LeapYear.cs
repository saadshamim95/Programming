using System;

namespace Functional
{
    class LeapYear
    {
        int year = 0;
        /// <summary>
        /// Leaps the year.
        /// </summary>
        public void leapYear()
        {
            while (year < 1000 || year > 9999)
            {
                Console.WriteLine("Enter year between 1000 & 9999:");
                year = Convert.ToInt32(Console.ReadLine());
            }
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine(year + " is a Leap Year");
            }
            else
            {
                Console.WriteLine(year + " is not a Leap Year");
            }
        }
    }
}