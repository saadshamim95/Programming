using System;

namespace Data_Structure
{
    class UnOrderedList
    {
        public void Hello()
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.add(10);
            ll.add(20);
            ll.add(30);
            ll.add(40);
            //Console.WriteLine("Linked List Size: " + ll.size());
            ll.Print();
            ll.remove(10);
            ll.Print();
            Console.WriteLine("Pop " + ll.pop());
            ll.Print();
            Console.WriteLine("Pop 0: " + ll.pop(0));
            ll.Print();
            //Console.WriteLine(ll.index(20));
        }
    }
}
