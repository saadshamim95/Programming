using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class VendingMachine
    {
        /// <summary>
        /// Returns the notes.
        /// </summary>
        /// <param name="amount">The amount.</param>
        public void returnNotes(int amount) {
            if (amount >= 1000)
            {
                int thousand = 0;
                while (amount >= 1000)
                {
                    thousand++;
                    totalnotes++;
                    amount = amount - 1000;
                }
                Console.WriteLine("Rs. 1000: " + thousand);
                returnNotes(amount);
            }
            else if (amount >= 500)
            {
                totalnotes++;
                amount = amount - 500;
                Console.WriteLine("Rs. 500: 1");
                returnNotes(amount);
            }
            else if (amount >= 100)
            {
                int hundred = 0;
                while (amount >= 100)
                {
                    hundred++;
                    totalnotes++;
                    amount = amount - 100;
                }
                Console.WriteLine("Rs. 100: " + hundred);
                returnNotes(amount);
            }
            else if (amount >= 50)
            {
                totalnotes++;
                amount = amount - 50;
                Console.WriteLine("Rs. 50: 1");
                returnNotes(amount);
            }
            else if (amount >= 20)
            {
                int twenty = 0;
                while (amount >= 20)
                {
                    twenty++;
                    totalnotes++;
                    amount = amount - 20;
                }
                Console.WriteLine("Rs.20: " + twenty);
                returnNotes(amount);
            }
            else if (amount >= 10)
            {
                totalnotes++;
                amount = amount - 10;
                Console.WriteLine("Rs.10: 1");
                returnNotes(amount);
            }
            else if (amount >= 5)
            {
                totalnotes++;
                amount = amount - 5;
                Console.WriteLine("Rs.5: 1");
                returnNotes(amount);
            }
            else if (amount >= 2)
            {
                int two = 0;
                while (amount >= 2)
                {
                    two++;
                    totalnotes++;
                    amount = amount - 2;
                }
                Console.WriteLine("Rs.2: " + two);
                returnNotes(amount);
            }
            else if (amount == 1)
            {
                totalnotes++;
                amount = amount - 1;
                Console.WriteLine("Rs.1: 1");
            }
            else {
                return;
            }
        }

        static int totalnotes = 0;
        /// <summary>
        /// Machines this instance.
        /// </summary>
        public void machine() {
            Console.Write("Enter the amount to be returned: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            returnNotes(amount);
            Console.WriteLine("Minimum Notes: " + totalnotes);
        }
    }
}
