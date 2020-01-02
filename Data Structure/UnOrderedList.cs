using System;
using System.IO;

namespace Data_Structure
{
    class UnOrderedList
    {
        public void Run()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            StreamReader sr = new StreamReader("C:/Users/Saad Shamim/Source/Repos/Programming/Data Structure/Input.txt");
            string line;
            string[] array = new string[11];
            int i = 0;
            while ((line = sr.ReadLine()) != null)
            {
                array[i] = line;
                i++;
            }
            for (int j = 0; j < array.Length; j++)
                linkedList.add(array[j]);
            //linkedList.Print();
            Console.Write("Enter the word you want to search: ");
            string search = Console.ReadLine();
            bool found = linkedList.search(search);
            if (!found)
                linkedList.append(search);
            System.IO.StreamWriter sw = new System.IO.StreamWriter(@"C:/Users/Saad Shamim/Source/Repos/Programming/Data Structure/Input.txt");
            foreach (string lines in array)
                sw.WriteLine(lines);
        }
    }
}
