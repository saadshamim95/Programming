using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented
{
    class Player
    {
        public void Sort(string[] array) {
            Console.WriteLine("Array Before Sorting:");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");

            //int count = 0;
            string first;
            //string second;
            int f;
            //int s;
            int[] arr = new int[array.Length];
            for (int i= 0; i < array.Length; i++) {
                first = array[i].Substring(2, array[i].Length - 2);
                f = Convert.ToInt32(first);
                arr[i] = f;
            }

            Console.Write("\nArray: ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
            /*for (int i = 0; i < 9; i++) {
                for (int j = 0; j < 8 - i; j++) {
                    first = array[j].Substring(2, array[j].Length - 2); 
                    f = Convert.ToInt32(first);
                    second = array[j + 1].Substring(2, array[j + 1].Length - 2);
                    s = Convert.ToInt32(second);
                    if (f > s) {
                        Console.WriteLine("Swapping {0} and {1}",array[i],array[j]);
                        string temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                    count++;
                }
            }
            Console.WriteLine("Count: " + count);
            Console.WriteLine("Array After Sorting:");
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");*/
        }
    }
}
