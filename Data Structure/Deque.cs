using System;

namespace Data_Structure
{
    class Deque<T>
    {
        private int front = -1;
        private int rear = -1;
        T[] array = new T[5];

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool isEmpty() {
            if (front == -1 && rear == -1)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Adds the front.
        /// </summary>
        /// <param name="item">The item.</param>
        public void addFront(T item) {
            if (isEmpty())
            {
                front++;
                rear++;
                array[front] = item;
            }
            else if (rear == (array.Length - 1)) {
                Console.WriteLine("Error! Deque is full...");
            }
            else
            {
                int i = rear;
                while (i >= front)
                {
                    array[i + 1] = array[i];
                    i--;
                }
                rear++;
                array[front] = item;
            }
        }

        /// <summary>
        /// Adds the rear.
        /// </summary>
        /// <param name="item">The item.</param>
        public void addRear(T item) {
            if (isEmpty())
            {
                front++;
                rear++;
                array[rear] = item;
            }
            else if (rear == (array.Length - 1)) {
                Console.WriteLine("Error! Deque is full...");
            }
            else {
                rear++;
                array[rear] = item;
            }
        }

        /// <summary>
        /// Removes the front.
        /// </summary>
        public void removeFront() {
            if (isEmpty())
                Console.WriteLine("Error! Deque has no item...");
            else if (front == rear)
            {
                rear = -1;
                front = -1;
            }
            else {
                for (int i = 1; i <= rear; i++)
                    array[i - 1] = array[i];
                rear--;
            }
        }

        /// <summary>
        /// Removes the rear.
        /// </summary>
        public void removeRear() {
            if (isEmpty())
                Console.WriteLine("Error! Deque has no item...");
            else if (front == rear) {
                rear = -1;
                front = -1;
            }
            else
                rear--;
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print() {
            if (isEmpty())
                return;
            else {
                for (int i = front; i <= rear; i++)
                    Console.Write(array[i] + " ");
            }
        }

        /// <summary>
        /// Sizes this instance.
        /// </summary>
        /// <returns></returns>
        public int size() {
            if (isEmpty())
                return 0;
            else
                return (rear - front + 1);
        }

        /// <summary>
        /// Gets the array.
        /// </summary>
        /// <returns></returns>
        public T[] getArray() {
            return array;
        } 
    }
}