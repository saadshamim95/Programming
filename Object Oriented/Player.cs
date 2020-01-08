using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented
{
    public class Player
    {
        public Player(string[] array) {
            QueueLinkedList<string> queueLinkedList = new QueueLinkedList<string>();
            for (int i = 0; i < array.Length; i++)
                queueLinkedList.enqueue(array[i]);
            Console.WriteLine(queueLinkedList);
        }

        public void sort() { 
            
        }
    }
}
