using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Data_Structure
{
    class Hashing
    {
        public void Chaining() {
            OrderedLinkedList<int>[] array = new OrderedLinkedList<int>[11];
            for (int i = 0; i < array.Length; i++)
                array[i] = new OrderedLinkedList<int>();
            StreamReader streamReader =new StreamReader(@"C:\Users\Saad Shamim\source\repos\Programming\Data Structure\Numbers.txt");
            string line;
            while ((line = streamReader.ReadLine()) != null) {
                int item = Convert.ToInt32(line);
                int pos = item % array.Length;
                //Console.Write("Pos: " + pos);
                array[pos].add(item);
            }
            streamReader.Close();
            print(array);
            Console.Write("Enter the number to Search: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int arrayNumber = number % array.Length;
            bool found = array[arrayNumber].Search(number);
            if (found) {
                int pos = array[arrayNumber].index(number);
                array[arrayNumber].pop(pos);
            }
            else
                array[arrayNumber].add(number);
            print(array);

            for (int i = 0; i < array.Length; i++) {
                array[i].PrintToFile(true);
            }
        }

        public void Test() {
            OrderedLinkedList<int> list = new OrderedLinkedList<int>();
            list.add(10);
            list.add(100);
            list.add(8);
            list.add(25);
            list.add(32);
            list.add(17);
            Console.Write("Before Pop: ");
            list.Print();
            list.pop(3);
            Console.Write("After Pop: ");
            list.Print();
            bool found = list.Search(32);
            if (found)
                Console.WriteLine("32 Found...");
            else
                Console.WriteLine("32 Not Found...");
        }

        public void print(OrderedLinkedList<int>[] array) {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("List {0}: ", i);
                array[i].Print();
            }
        }
    }
}
