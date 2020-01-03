using System;
using System.Collections.Generic;

namespace Data_Structure
{
    class OrderedLinkedList<T>
    {
        /// <summary>
        /// Basic building block of Linked List
        /// </summary>
        class Node {
            public T data;
            public Node next;
        }

        Comparer<T> comparer = Comparer<T>.Default;
        Node head = null;

        /// <summary>
        /// Adds the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void add(T data) {
            Node node = new Node();
            node.data = data;
            node.next = null;

            if (isEmpty() || comparer.Compare(data, head.data) <= 0) {
                node.next = head;
                head = node;
            }
            else
            {
                Node current = head;
                while (current.next != null && comparer.Compare(current.next.data, node.data) < 0)
                    current = current.next;
                node.next = current.next;
                current.next = node;
            }
        }

        /// <summary>
        /// Removes the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void remove(T data) {
            Node current = head;
            Node prev = null;
            if (object.Equals(head.data, data)) {
                head = head.next;
                current = null;
            }
            else {
                while (current.next != null)
                {
                    if (comparer.Compare(current.data, data) == 0)
                        break;
                    prev = current;
                    current = current.next;
                }
                prev.next = current.next;
                current = null;
            }
        }

        /// <summary>
        /// Searches the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public bool Search(T data) {
            bool found = false;
            Node current = head;
            return found;
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool isEmpty() {
            if (head == null)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Sizes this instance.
        /// </summary>
        /// <returns></returns>
        public int size() {
            if (isEmpty())
                return 0;
            
            int count = 1;
            Node current = head;
            while (current.next != null) {
                count++;
                current = current.next;
            }
            return count;
        }

        public int index(T data) {
            int pos = 0;
            Node current = head;
            while (current.next != null) {
                pos++;
                current = current.next;
            }
            return pos;
        }

        public T pop() {
            T temp;
            Node current = head;
            while (current.next != null)
                current = current.next;
            temp = current.data;
            //current = null;
            remove(current.data);
            return temp;
        }

        public T pop(int position) {
            Node current = head;
            while (position > 0) {
                current = current.next;
                position--;
            }
            remove(current.data);
            return current.data;
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print() {
            Node node = head;
            while (node.next != null) {
                Console.Write(node.data+" ");
                node = node.next;
            }
            Console.WriteLine(node.data);
        }
    }
}
