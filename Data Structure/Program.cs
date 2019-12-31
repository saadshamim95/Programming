using System;

namespace Data_Structure
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            BalancedParanthesis balancedParanthesis = new BalancedParanthesis();
            balancedParanthesis.check();
            /*Queue<int> queue = new Queue<int>();
            queue.enqueue(2);
            queue.enqueue(3);
            queue.enqueue(4);
            Console.Write("Queue: ");
            queue.Print();
            Console.WriteLine();
            queue.dequeue();
            queue.enqueue(5);
            Console.Write("Queue: ");
            queue.Print();
            Console.WriteLine();
            queue.dequeue();
            queue.dequeue();
            Console.Write("Queue: ");
            queue.Print();
            Console.WriteLine();*/

            int choice;
            int item;
            Deque<int> deque = new Deque<int>();
            do {
                Console.WriteLine("\n1: Add Front\n2: Add Rear\n3: Remove Front\n4: Remove Rear\n5: Print\n6: Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice) {
                    case 1:
                        item = Convert.ToInt32(Console.ReadLine());
                        deque.addFront(item);
                        break;
                    case 2:
                        item = Convert.ToInt32(Console.ReadLine());
                        deque.addRear(item);
                        break;
                    case 3:
                        deque.removeFront();
                        break;
                    case 4:
                        deque.removeRear();
                        break;
                    case 5:
                        deque.Print();
                        break;
                    case 6:
                        break;
                }
            } while (choice != 6);
        }
    }
}
