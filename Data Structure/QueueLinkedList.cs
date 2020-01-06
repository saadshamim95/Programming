using System;

namespace Data_Structure
{
    class QueueLinkedList<T>
    {
        LinkedList<T> LinkedList = new LinkedList<T>();

        /// <summary>
        /// Enqueues the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void enqueue(T data) {
            LinkedList.add(data);
        }

        /// <summary>
        /// Dequeues this instance.
        /// </summary>
        /// <returns></returns>
        public T dequeue() {
            T item = LinkedList.removeFront();
            return item;
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool isEmpty() {
            return LinkedList.isEmpty();
        }

        /// <summary>
        /// Sizes this instance.
        /// </summary>
        /// <returns></returns>
        public int size() {
            return LinkedList.size();
        }
    }
}
