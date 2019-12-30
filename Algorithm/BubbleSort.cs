using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class BubbleSort
    {
        /// <summary>
        /// Sorts this instance.
        /// </summary>
        public void Sort() {
            Console.Write("Enter the number of elements you want to add: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[num];
            for (int i = 0; i < num; i++) {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            array = Utility.BubbleSort(array);
            Console.WriteLine();
            Console.WriteLine("After Sorting: ");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
        }
    }
}
