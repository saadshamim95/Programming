using System;

namespace Object_Oriented
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Student");
            Console.WriteLine("2: Inventory management for Rice, Pulses, Wheat");
            Console.WriteLine("3: Stock Portfolio");
            Console.WriteLine("4: Stock Account Management");
            Console.WriteLine("5: Deck of Cards");
            Console.WriteLine("6: Regular Expression");
            Console.WriteLine("7: Clinique Management");
            int choice = 0;
            while (!(choice > 0 && choice < 8))
            {
                try
                {
                    Console.Write("Enter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException exception)
                {
                    Console.WriteLine(exception);
                }
            }

            switch (choice)
            {
                case 1:
                    StudentTest studentTest = new StudentTest();
                    studentTest.Test();
                    break;
                case 2:
                    InventoryManager manager = new InventoryManager();
                    manager.Test();
                    break;
                case 3:
                    StockPortfolio portfolio = new StockPortfolio();
                    portfolio.Test();
                    break;
                case 4:
                    
                    break;
                case 5:
                    DeckOfCards deck = new DeckOfCards();
                    deck.Initialize();
                    break;
                case 6:
                    RegularExpression regularExpression = new RegularExpression();
                    regularExpression.checkExpression();
                    break;
                case 7:

                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
        }
    }
}