using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class BinarySwapNibbles
    {
        /// <summary>
        /// Swaps the nibbles of the specified binary.
        /// </summary>
        /// <param name="binary">The binary.</param>
        /// <returns></returns>
        public int[] swap(int[] binary) {
            int mid = binary.Length / 2;
            for (int i = 0; i < mid; i++) {
                int temp = binary[i];
                binary[i] = binary[i + mid];
                binary[i + mid] = temp;
            }
            return binary;
        }

        /// <summary>
        /// Prints the specified array in reverse.
        /// </summary>
        /// <param name="array">The array.</param>
        public void Print(int[] array) {
            for (int i = 7; i >= 0; i--)
                Console.Write(array[i]);
        }
        public int ToDecimal(int[] binary) {
            int result = 0;
            for (int i = 0; i < 8; i++) {
                if (binary[i] == 1)
                    result = result + (int)Math.Pow(2, i);
            }
            return result;
        }

        public void swapNibbles() {
            Console.Write("Enter the value: ");
            int value = Convert.ToInt32(Console.ReadLine());
            int[] binary = Utility.toBinary(value);
            Console.Write("In Binary: ");
            Print(binary);
            Console.WriteLine();
            int[] newBinary = swap(binary);
            Console.Write("After Swapping: ");
            Print(newBinary);
            Console.WriteLine();
            int dec = ToDecimal(newBinary);
            Console.WriteLine("After swapping nibbles new Decimal value: " + dec);
        }
    }
}
