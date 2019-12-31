using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structure
{
    class Queue<T>
    {
        T[] array = new T[10];
        public int front = -1;
        public int rear = -1;

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

        public bool isEmpty() {
            if (front == -1 && rear == -1)
                return true;
            else
                return false;
        }

        public int size() {
            if (isEmpty())
                return 0;
            else if (front == rear)
                return 1;
            else
                return (rear - front + 1);
        }

        public void Print() {
            for (int i = front; i <= rear; i++) {
                Console.Write(array[i] + " ");
            }
        }
    }
}
