using System;

namespace Object_Oriented
{
    class QueueUsingLinkedList<T>
    {
        public class Node {
            public T data;
            public Node next;

            /// <summary>
            /// Initializes a new instance of the <see cref="Node"/> class.
            /// </summary>
            /// <param name="value">The value.</param>
            public Node(T value) {
                data = value;
                next = null;
            }
        }

        Node head = null;

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
        /// Enqueues the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void enqueue(T data) {
            Node node = new Node(data);
            if (isEmpty())
                head = node;
            else {
                Node current = head;
                while (current.next != null) {
                    current = current.next;
                }
                current.next = node;
            }
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print() {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
        }
    }
}