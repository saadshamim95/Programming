using System;

namespace Data_Structure
{
    class NumberOfBST
    {
        /// <summary>
        /// Calculates this instance.
        /// </summary>
        public void Calculate() {
            Console.Write("Enter number of nodes in BST: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[num + 1];
            array[0] = 1;
            array[1] = 1;
            for (int i = 2; i <= num; i++) {
                for (int j = 0; j < i; j++) {
                    array[i] = array[i] + array[j] * array[i - j - 1];
                }
            }
            Console.WriteLine("Number of BST with {0} nodes: {1}", num, array[num]);
        }
    }
}
