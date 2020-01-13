using System;

namespace Object_Oriented
{
    class Player
    {
        /// <summary>
        /// Sorts the specified array.
        /// </summary>
        /// <param name="array">The array.</param>
        public void Sort(string[] array) {
            string first;
            string second;
            int integerFirst;
            int integerSecond;
            
            for (int i = 0; i < array.Length; i++) {
                for (int j = 0; j < array.Length - i - 1; j++) {
                    first = array[j].Substring(2, array[j].Length - 2);
                    second = array[j + 1].Substring(2, array[j + 1].Length - 2);
                    if (first.Equals("Jack"))
                        first = "11";
                    else if (first.Equals("Queen"))
                        first = "12";
                    else if (first.Equals("King"))
                        first = "13";
                    else if (first.Equals("Ace"))
                        first = "14";
                    if (second.Equals("Jack"))
                        second = "11";
                    else if (second.Equals("Queen"))
                        second = "12";
                    else if (second.Equals("King"))
                        second = "13";
                    else if (second.Equals("Ace"))
                        second = "14";

                    integerFirst = Convert.ToInt32(first);
                    integerSecond = Convert.ToInt32(second);
                    if (integerFirst > integerSecond) {
                        string temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }
            }
        }
    }
}