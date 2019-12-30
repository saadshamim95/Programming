using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class MergeSort
    {
        /// <summary>
        /// Merges the sort.
        /// </summary>
        /// <param name="array">The array.</param>
        public void mergeSort(string[] array) {
            int n = array.Length;
            if (n < 2)
                return;
            else {
                int mid = (n + 1) / 2;
                string[] left = new string[mid];
                string[] right = new string[n - mid];
                for (int i = 0; i < mid; i++)
                    left[i] = array[i];
                for (int i = mid; i < n; i++)
                    right[i - mid] = array[i];

                Console.Write("Left Array: ");
                Print(left);
                Console.WriteLine();

                Console.Write("Right Array: ");
                Print(right);
                Console.WriteLine();

                mergeSort(left);
                mergeSort(right);
                merge(array, left, right);
            }
        }

        /// <summary>
        /// Merges the specified array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        public void merge(string[] array, string[] left, string[] right) {
            int sizeLeft = left.Length;
            int sizeRight = right.Length;
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < sizeLeft && j < sizeRight) {
                if (left[i].CompareTo(right[j]) < 0) { 
                    array[k] = left[i];
                    i++;
                }
                else {
                    array[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < sizeLeft) {
                array[k] = left[i];
                i++;
                k++;
            }

            while (j < sizeRight) {
                array[k] = right[j];
                j++;
                k++;
            }
        }
        
        public void Print(string[] array) {
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
        }

        public void Sort() {
            /*Console.Write("Enter the number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[n];
            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
                array[i] = Console.ReadLine();*/
            string[] array = { "Saad", "Fahad", "Saba", "Zeeshan", "Omaira", "Omar", "Ashhar", "Monis", "Mayank" };
            mergeSort(array);
            Console.WriteLine("After Sorting:");
            Print(array);
        }
    }
}