using System;
using System.IO;

namespace Data_Structure
{
    class UnOrderedList
    {
        public void Run()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            StreamReader streamReader = new StreamReader(@"C:\Users\Saad Shamim\source\repos\Programming\Data Structure\Input.txt");
            string line;
            while ((line = streamReader.ReadLine()) != null)
            {
                linkedList.add(line);
            }
            streamReader.Close();
            //linkedList.Print();
            Console.Write("Enter the word you want to search: ");
            string search = Console.ReadLine();
            bool found = linkedList.search(search);
            if (!found)
                linkedList.add(search);
            else {
                int pos = linkedList.index(search);
                Console.WriteLine("Index: " + pos);
            }
            //linkedList.Print();
            linkedList.PrinttoFile();
        }
    }
}