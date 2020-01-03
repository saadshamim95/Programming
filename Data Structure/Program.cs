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
            Console.WriteLine("1: UnOrdered List");
            Console.WriteLine("2: Ordered List");
            Console.WriteLine("3: Simple Balanced Parentheses");
            Console.WriteLine("4: Simulate Banking Cash Counter");
            Console.WriteLine("5: Palindrome-Checker");
            Console.WriteLine("6: Hashing function to search a Number in a slot");
            Console.WriteLine("7: Number of Binary Search Tree");
            Console.WriteLine("8: Calendar");
            Console.WriteLine("9: Question 9");
            Console.WriteLine("10: Question 10");
            Console.WriteLine("11: Question 11");
            Console.WriteLine("12: Question 12");
            Console.WriteLine("13: Question 13");
            Console.WriteLine("14: Question 14");
            int choice = 0;
            while (!(choice > 0 && choice < 15))
            {
                try
                {
                    Console.Write("Enter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    //Console.WriteLine(Ex);
                }
            }
            switch (choice)
            {
                case 1:
                    UnOrderedList list = new UnOrderedList();
                    list.Run();
                    break;
                case 2:
                    OrderedList orderedList = new OrderedList();
                    orderedList.Run();
                    break;
                case 3:
                    BalancedParanthesis balancedParanthesis = new BalancedParanthesis();
                    balancedParanthesis.Check();
                    break;
                case 4:
                    BankingCashCounter cashCounter = new BankingCashCounter();
                    cashCounter.Simulate();
                    break;
                case 5:
                    PalindromeChecker palindrome = new PalindromeChecker();
                    palindrome.Check();
                    break;
            }
        }
    }
}