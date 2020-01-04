using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    class StackLinkedList<T>
    {
        LinkedList<T> LinkedList = new LinkedList<T>();
        public void push(T data) {
            LinkedList.add(data);
        }

        public T pop() {
            T item = LinkedList.pop();
            return item;
        }

        public T peek() {
            T item = LinkedList.lastItem();
            return item;
        }

        public bool isEmpty() {
            return LinkedList.isEmpty();
        }

        public int size() {
            return LinkedList.size();
        }
    }
}
