using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class Utility
    {
        public static bool IsAnagrams(string str1, string str2) {
            char[] array1 = str1.ToLower().ToCharArray();
            char[] array2 = str2.ToLower().ToCharArray();
            Array.Sort(array1);
            Array.Sort(array2);
            string string1 = new string(array1);
            string string2 = new string(array2);
            if (string1.Equals(string2))
                return true;
            else
                return false;
        }

        public static bool IsPrime(int value) {
            bool flag=true;
            if (value < 2)
                flag = false;
            else {
                for (int i = 2; i <= value / 2; i++)
                {
                    if (value % i == 0)
                    {
                        flag = false;
                        break;
                    }
                }
            }
            return flag;
        }

        public static bool IsPalindrome(int value) {
            int reverse = value;
            int sum = 0;
            while (reverse > 0) {
                int d = reverse % 10;
                sum = sum * 10 + d;
                reverse = reverse / 10;
            }
            if (sum == value)
                return true;
            else
                return false;
        }

        public static int BinarySearch(int search, int start, int end, int[] array) {
            int mid = (start + end) / 2;
            while (start <= end) {
                if (search == array[mid])
                    return mid+1;
                else if (search > array[mid])
                    return BinarySearch(search, mid + 1, end, array);
                else
                    return BinarySearch(search, start, mid - 1, array);
            }
            return -1;
        }

        public static int BinarySearch(string search, int start, int end, string[] array)
        {
            int mid = (start + end) / 2;
            while (start <= end)
            {
                if (search.ToLower() == array[mid].ToLower())
                    return mid+1;
                else if (search.ToLower().CompareTo(array[mid].ToLower()) > 0)
                    return BinarySearch(search, mid + 1, end, array);
                else
                    return BinarySearch(search, start, mid - 1, array);
            }
            return -1;
        }

        public static int[] InsertionSort(int[] array) {
            for (int i = 1; i < array.Length; i++) {
                int temp = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > temp) {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
            return array;
        }

        public static string[] InsertionSort(string[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                string temp = array[i];
                int j = i - 1;
                while (j >= 0 && array[j].CompareTo(temp) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }
            return array;
        }

        public static int[] BubbleSort(int[] array) {
            for (int i = 0; i < array.Length - 1; i++) {
                bool swapping = false;
                for (int j = 0; j < array.Length - i - 1; j++) {
                    if (array[j] > array[j + 1]) {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapping = true;
                    }
                }
                if (swapping == false)
                    break;
            }
            return array;
        }

        public static string[] BubbleSort(string[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                bool swapping = false;
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        string temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapping = true;
                    }
                }
                if (swapping == false)
                    break;
            }
            return array;
        }

        public static int dayOfWeek(int M, int D, int Y) {
            int y0 = Y - (14 - M) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = M + 12 * ((14 - M) / 12) - 2; 
            int d0 = (D + x + 31 * m0 / 12) % 7;
            return d0;
        }

        public static double temperatureConversion(double value, char c) {
            double convert;
            if (c == 'F')
                convert = ((value - 32) * 5) / 9;
            else 
                convert = 1.8 * value + 32;
            return convert;
        }

        public static double monthlyPayment(int P, double Y, double R) {
            double n = 12 * Y;
            double r = R / (12 * 100);
            double payment = (P * r) / (1 - Math.Pow(1 + r, -n));
            return payment;
        }

        public static double sqrt(int c) {
            double t = c;
            double epsilon = Math.Pow(Math.E, -15);
            while (Math.Abs(t - (c / t)) > epsilon * t)
            {
                t = (t + (c / t)) / 2;
            }
            return t;
        }

        public static int[] toBinary(int value) {
            int[] binary = new int[8];
            while (value != 0) {
                int i = 1;
                while (!(Math.Pow(2, i) > value)) {
                    //Console.Write("Here ");
                    i++;
                }
                value = value - (int)Math.Pow(2, i - 1);
                binary[i - 1] = 1;
            }
            return binary;
        }
    }
}