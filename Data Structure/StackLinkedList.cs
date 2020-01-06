using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    class StackLinkedList<T>
    {
        LinkedList<T> LinkedList = new LinkedList<T>();

        /// <summary>
        /// Pushes the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void push(T data) {
            LinkedList.add(data);
        }

        /// <summary>
        /// Pops this instance.
        /// </summary>
        /// <returns></returns>
        public T pop() {
            T item = LinkedList.pop();
            return item;
        }

        /// <summary>
        /// Peeks this instance.
        /// </summary>
        /// <returns></returns>
        public T peek() {
            T item = LinkedList.lastItem();
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
