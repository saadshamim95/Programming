using System;

namespace Data_Structure
{
    class BankingCashCounter
    {
        /// <summary>
        /// Simulates this instance.
        /// </summary>
        public void Simulate() {
            int balance = 1000;
            int choice = 0;
            Queue<int> queue = new Queue<int>();
            do {
                Console.WriteLine("1: Deposit");
                Console.WriteLine("2: Withdraw");
                Console.WriteLine("3: Complete Step");
                Console.WriteLine("4: Balance Left");
                Console.WriteLine("5: Close Bank");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice) {
                    case 1:
                        Console.Write("Enter Deposit Amount: ");
                        int deposit = Convert.ToInt32(Console.ReadLine());
                        queue.enqueue(deposit);
                        break;
                    case 2:
                        Console.Write("Enter Withdraw Amount: ");
                        int withdraw = Convert.ToInt32(Console.ReadLine());
                        withdraw = (-1) * withdraw;
                        queue.enqueue(withdraw);
                        break;
                    case 3:
                        if (queue.front == -1) {
                            Console.WriteLine("No one in queue...");
                            break;
                        }
                        int amountLeft = balance + queue.returnFront();
                        if (amountLeft >= 0)
                            balance = balance + queue.returnFront();
                        else
                            Console.WriteLine("Balance not enough for withdrawal...");
                        queue.dequeue();
                        break;
                    case 4:
                        Console.WriteLine("Balance Left: " + balance);
                        break;
                }
            } while (choice != 5);
        }
    }
}