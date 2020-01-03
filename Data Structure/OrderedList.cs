using System;
using System.Collections.Generic;
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
            orderedLinkedList.add(10);
            orderedLinkedList.add(20);
            orderedLinkedList.add(30);
            orderedLinkedList.add(15);
            orderedLinkedList.Print();
            /*int pos = orderedLinkedList.index(15);
            Console.WriteLine("15 at position: " + pos);*/
            //orderedLinkedList.remove(30);
            //orderedLinkedList.pop();
            int item = orderedLinkedList.pop(3);
            Console.WriteLine("Pop: " + item);
            orderedLinkedList.Print();
        }
    }
}
