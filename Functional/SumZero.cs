using System;
using System.Collections;

namespace Functional
{
    class SumZero
    {
        /// <summary>
        /// Checks the sum for zero.
        /// </summary>
        public void checkSumForZero() {
            /*Console.Write("Enter the number of Integers");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter the Array: ");
            for (int i = 0; i < n; i++)
                array[i] = Convert.ToInt32(Console.ReadLine());*/
            int[] array = { 5, 4, 3, -3, -1, -2, 6, -9, 7, -4 };
            int n = 10;
            int count = 0;
            ArrayList triplets = new ArrayList();
            for (int i = 0; i < n - 2; i++) {
                for (int j = i + 1; j < n - 1; j++) {
                    for (int k = j + 1; k < n; k++) {
                        if (array[i] + array[j] + array[k] == 0) {
                            triplets.Add(array[i]);
                            triplets.Add(array[j]);
                            triplets.Add(array[k]);
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine("Total Triplets: "+count);
            for (int i = 0; i < 3 * count; i = i + 3) {
                for (int j = 0; j < 3; j++) {
                    Console.Write(triplets[i + j] + " ");
                }
                Console.WriteLine();
            }     
        }
    }
}