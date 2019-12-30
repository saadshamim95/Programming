using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class ConvertToBinary
    {
        public void conversion() {
            Console.Write("Enter the value: ");
            int value = Convert.ToInt32(Console.ReadLine());
            Console.Write("Binary representation of " + value + ": ");
            int[] result = Utility.toBinary(value);
            for (int i = 7; i >= 0; i--)
                Console.Write(result[i]);
        }
    }
}
