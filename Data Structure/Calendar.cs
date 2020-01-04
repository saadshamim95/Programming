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
                    if (Utility.isLeapYear(year))
                        months[2] = 29;
                }

                int firstDay = Utility.dayOfWeek(month, 1, year);
                for (int i = 0; i < 7; i++)
                    Console.Write(" {0} ",day[i]);
                Console.WriteLine();
                int k = 1;
                bool flag = false;
                for (int i = 0; i < 6; i++) {
                    for (int j = 0; j < 7; j++) {
                        /// Printing spaces till firstDay
                        while (firstDay > 0) {
                            Console.Write("   ");
                            firstDay--;
                            j++;    /// Incrementing j
                        }

                        if (k > months[month]) {
                            flag = true;
                            break;
                        }

                        if (k < 10)
                            Console.Write(" ");

                        Console.Write(k + " ");
                        k++;
                    }
                    if (flag)
                        break;
                    Console.WriteLine();
                }
            }
        }
    }
}