using System;

namespace Data_Structure
{
    class QueueLinkedList<T>
    {
        LinkedList<T> LinkedList = new LinkedList<T>();
        public void enqueue(T data) {
            LinkedList.add(data);
        }

        public T dequeue() {
            T item = LinkedList.removeFront();
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
