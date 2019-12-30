using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class FindingNumber
    {
        public void Find() {
            Console.Write("Enter the value of N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Think of a number between 0 and " + (N - 1) + ":");
            //int value = Convert.ToInt32(Console.ReadLine());
            int start = 0;
            int end = N - 1;
            Console.WriteLine("1: True 0: False");
            bool answer = true;
            while (start <= end) {
                int mid = (start + end) / 2;
                Console.Write("Is you number between {0} and {1}:", mid, end);
                int value = Convert.ToInt32(Console.ReadLine());
                if (value == 1)
                    answer = true;
                else
                    answer = false;

                if (start == end)
                    break;
                else if (answer)
                    start = mid + 1;
                else
                    end = mid - 1;
            }
            if (answer)
                Console.WriteLine("Your number is " + start);
            else
                Console.WriteLine("Your number is " + (start - 1));
        }
    }
}
