using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Data_Structure
{
    class OrderedList
    {
        /// <summary>
        /// Runs this instance.
        /// </summary>
        public void Run() {
            OrderedLinkedList<int> orderedLinkedList = new OrderedLinkedList<int>();
            StreamReader streamReader = new StreamReader("Numbers.txt");
            string item;
            while ((item = streamReader.ReadLine()) != null)
                orderedLinkedList.add(Convert.ToInt32(item));
            streamReader.Close();
            Console.WriteLine("Items in OrderedLinkedList Linked List are: ");
            orderedLinkedList.Print();
            Console.Write("Enter a Number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            bool found = orderedLinkedList.Search(number);
            if (found)
                orderedLinkedList.remove(number);
            else
                orderedLinkedList.add(number);
            Console.WriteLine("Modified Linked List: ");
            orderedLinkedList.Print();
            orderedLinkedList.PrintToFile();
        }
    }
}
