using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class InsertionSort
    {
        public void Sort() {
            Console.Write("Enter the number of string you want to enter: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[n];
            for (int i = 0; i < n; i++)
                array[i] = Console.ReadLine();
            array = Utility.InsertionSort(array);
            Console.WriteLine();
            Console.WriteLine("After Sorting: ");
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }
    }
}
