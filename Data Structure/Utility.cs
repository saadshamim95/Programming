using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    class Utility
    {
        /// <summary>
        /// Determines whether the specified number is prime.
        /// </summary>
        /// <param name="num">The number.</param>
        /// <returns>
        ///   <c>true</c> if the specified number is prime; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsPrime(int num)
        {
            bool flag = true;
            if (num < 2)
                flag = false;
            else
            {
                for (int i = 2; i < num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        flag = false;
                        break;
                    }
                }
            }
            return flag;
        }

        /// <summary>
        /// Determines whether the specified STR1 is anagrams.
        /// </summary>
        /// <param name="str1">The STR1.</param>
        /// <param name="str2">The STR2.</param>
        /// <returns>
        ///   <c>true</c> if the specified STR1 is anagrams; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsAnagrams(string str1, string str2)
        {
            char[] array1 = str1.ToLower().ToCharArray();
            char[] array2 = str2.ToLower().ToCharArray();
            Array.Sort(array1);
            Array.Sort(array2);
            string string1 = new string(array1);
            string string2 = new string(array2);
            if (string1.Equals(string2))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Determines whether [is leap year] [the specified year].
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>
        ///   <c>true</c> if [is leap year] [the specified year]; otherwise, <c>false</c>.
        /// </returns>
        public static bool isLeapYear(int year)
        {
            bool value = false;
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                value = true;
            return value;
        }

        /// <summary>
        /// Days the of week.
        /// </summary>
        /// <param name="M">The m.</param>
        /// <param name="D">The d.</param>
        /// <param name="Y">The y.</param>
        /// <returns></returns>
        public static int dayOfWeek(int M, int D, int Y)
        {
            int y0 = Y - (14 - M) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = M + 12 * ((14 - M) / 12) - 2;
            int d0 = (D + x + 31 * m0 / 12) % 7;
            return d0;
        }
    }
}
