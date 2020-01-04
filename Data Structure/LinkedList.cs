using System;
using System.IO;

namespace Data_Structure
{
    class LinkedList<T>
    {
        class Node
        {
            public T data;
            public Node next;        
        }

        Node head=null;

        /// <summary>
        /// Adds the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void add(T data) {
            Node node = new Node();
            node.data = data;
            node.next = null;

            if (head == null)
            {
                head = node;
            }
            else
            {
                Node n = head;
                while (n.next != null)
                    n = n.next;
                n.next = node;
            }
        }

        /// <summary>
        /// Removes the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void remove(T data) {
            int position = index(data);
            Node n = head;
            Node temp = null;

            if (position == 0)
                head = head.next;
            else {
                while (position > 1)
                {
                    n = n.next;
                    position--;
                }
                temp = n.next;
                n.next = temp.next;
                temp = null;
            }
        }

        /// <summary>
        /// Searches the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public bool search(T data) {
            Node n = head;
            bool found = false;
            while (n.next != null) {
                //T temp = n.data;
                if (object.Equals(n.data, data))
                {
                    found = true;
                    break;
                }
                n = n.next;
            }
            return found;
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool isEmpty()
        {
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
            Node n = head;
            while (n.next != null) {
                count++;
                n = n.next;
            }
            return count;
        }

        /// <summary>
        /// Appends the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public void append(T data) {
            add(data);
        }

        /// <summary>
        /// Indexes the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns></returns>
        public int index(T data) {
            Node n = head;
            int count = 1;
            while (!(object.Equals(n.data,data)))
            {
                count++;
                n = n.next;
            }
            return count;
        }

        /// <summary>
        /// Inserts the specified index.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <param name="data">The data.</param>
        public void insert(int index, T data) {
            Node node = new Node();
            node.data = data;
            node.next = null;

            if (index == 0)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node n = head;
                while (index > 1) {
                    n = n.next;
                    index--;
                }
                node.next = n.next;
                n.next = node;
            }
        }

        /// <summary>
        /// Pops this instance.
        /// </summary>
        /// <returns></returns>
        public T pop() {
            int position = size() - 1;
            Node n = head;
            Node temp = null;
            while (position > 1)
            {
                n = n.next;
                position--;
            }
            temp = n.next;
            n.next = temp.next;
            return temp.data;
        }

        /// <summary>
        /// Pops the specified position.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <returns></returns>
        public T pop(int position) {
            Node n = head;
            Node temp = null;
            if (position == 0) {
                temp = head;
                head = head.next;
                return temp.data;
            }
            while (position > 1) {
                n = n.next;
                position--;
            }
            temp = n.next;
            n.next = temp.next;
            return temp.data;
        }

        /// <summary>
        /// Lasts the item.
        /// </summary>
        /// <returns></returns>
        public T lastItem() {
            Node current = head;
            while (current.next != null)
                current = current.next;
            return current.data;
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print() {
            Node n = head;
            while (n.next != null) {
                Console.Write(n.data + " ");
                n = n.next;
            }   
            Console.WriteLine(n.data);
        }

        public void PrinttoFile() {
            Node n = head;
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\Saad Shamim\source\repos\Programming\Data Structure\Output.txt");
            while (n.next != null) {
                streamWriter.WriteLine(n.data);
                n = n.next;
            }
            streamWriter.WriteLine(n.data);
            streamWriter.Close();
        }
    }
}