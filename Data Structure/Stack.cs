using System;

namespace Data_Structure
{
    class Stack<T>
    {
        T[] array = new T[10];
        public int top=-1;
        /// <summary>
        /// Prevents a default instance of the <see cref="Stacks"/> class from being created.
        /// </summary>
        public Stack() {
            top = -1;
        }

        /// <summary>
        /// Pushes the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public void push(T item) {
            if (top == 10) {
                Console.WriteLine("Error! Stack Overflown...");
                return;
            }
            array[++top] = item;
        }

        /// <summary>
        /// Pops this instance.
        /// </summary>
        /// <returns></returns>
        public void pop() {
            if (top == -1) {
                Console.WriteLine("Error! Stack has no element to pop...");
                return;
            } 
            T item = array[top];
            top--;
            //return item;
        }

        /// <summary>
        /// Peeks this instance.
        /// </summary>
        /// <returns></returns>
        T peek() {
            return array[top];
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public bool isEmpty() {
            if (top == -1)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Sizes this instance.
        /// </summary>
        /// <returns></returns>
        public int size() {
            return (top + 1);
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print() {
            for (int i = 0; i <= top; i++)
                Console.Write(array[i] + " ");
        }
    }
}