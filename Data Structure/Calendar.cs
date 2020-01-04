using System;

namespace Data_Structure
{
    class Calendar
    {
        /// <summary>
        /// Prints the month.
        /// </summary>
        public void printMonth() {
            int[] months = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            char[] day = { 'S', 'M', 'T', 'W', 'T', 'F', 'S' };
            Console.Write("Enter Month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (month < 1 && month > 12) {
                Console.WriteLine("Month is out of Range");
            }
            else {
                if (month == 2) {
                    if (isLeapYear(year))
                        months[2] = 29;
                }

                int firstDay = dayOfWeek(month, 1, year);
                for (int i = 0; i < 7; i++)
                    Console.Write(" {0} ",day[i]);
                Console.WriteLine();
                int k = 1;
                for (int i = 0; i < 6; i++) {
                    for (int j = 0; j < 7; j++) {
                        /// Printing spaces till firstDay
                        ///
                        while (firstDay > 0) {
                            Console.Write("   ");
                            firstDay--;
                            j++;    /// Incrementing j
                        }

                        if (k > months[month])
                            break;

                        if (k < 10)
                            Console.Write(" ");

                        Console.Write(k + " ");
                        k++;
                    }
                    Console.WriteLine();
                }
            }
        }

        /// <summary>
        /// Determines whether [is leap year] [the specified year].
        /// </summary>
        /// <param name="year">The year.</param>
        /// <returns>
        ///   <c>true</c> if [is leap year] [the specified year]; otherwise, <c>false</c>.
        /// </returns>
        public bool isLeapYear(int year) {
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
        public int dayOfWeek(int M, int D, int Y)
        {
            int y0 = Y - (14 - M) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = M + 12 * ((14 - M) / 12) - 2;
            int d0 = (D + x + 31 * m0 / 12) % 7;
            return d0;
        }
    }
}