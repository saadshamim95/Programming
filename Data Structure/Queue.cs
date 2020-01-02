using System;

namespace Data_Structure
{
    class Queue<T>
    {
        T[] array = new T[4];
        public int front = -1;
        public int rear = -1;

        /// <summary>
        /// Enqueues the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void enqueue(T item) {
            if (isEmpty())
            {
                front++;
                rear++;
            }
            else if (rear == (array.Length - 1))
            {
                Console.WriteLine("Error! Can't Enqueue, Queue is full...");
                return;
            }
            else
                rear++;
            array[rear] = item;
        }

        /// <summary>
        /// Dequeues this instance.
        /// </summary>
        public void dequeue() {
            if (isEmpty())
                return;
            else if (front == rear)
            {
                front = -1;
                rear = -1;
            }
            else
            {
                int i = front;
                while (i < rear) {
                    array[i] = array[i + 1];
                    i++;
                }
                rear--;
            }
        }

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
        /// Prints this instance.
        /// </summary>
        public void Print() {
            for (int i = front; i <= rear; i++) {
                Console.Write(array[i] + " ");
            }
        }

        public T returnFront() {
            return array[front];
        }
    }
}