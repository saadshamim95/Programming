using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Algorithm
{
    class BinarySearch
    {
        /// <summary>
        /// Prints the specified array.
        /// </summary>
        /// <param name="array">The array.</param>
        public void Print(string[] array) {
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }
        
        /// <summary>
        /// Binaries the search.
        /// </summary>
        public void binarySearch() {
            string[] array = new string[10];
            try
            {
                using (StreamReader streamReader = new StreamReader("C:/Users/Saad Shamim/source/repos/BridgeLabz/Algorithm/Input.txt")) {
                    string line;
                    int i = 0;
                    while ((line = streamReader.ReadLine()) != null) {
                        array[i] = line;
                        i++;
                    }
                }
            }
            catch (Exception ex) {
                Console.WriteLine("File couldn't be read.");
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Before Sorting:");
            Print(array);
            array = Utility.BubbleSort(array);
            Console.WriteLine("After Sorting:");
            Print(array);
            Console.Write("Enter the string you want to search: ");
            string search = Console.ReadLine();
            int position = Utility.BinarySearch(search, 0, array.Length, array);
            if (position == -1)
                Console.WriteLine("Not Found!");
            else
                Console.WriteLine(search + " found at location " + position);
        }
    }
}
