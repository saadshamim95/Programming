using System;

namespace Object_Oriented
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("1: Student");
            Console.WriteLine("2: Address Book");
            Console.WriteLine("3: Inventory Management for Rice, Pulses, Wheat");
            Console.WriteLine("4: Stock Portfolio");
            Console.WriteLine("5: Stock Account Management");
            Console.WriteLine("6: Deck of Cards");
            Console.WriteLine("7: Regular Expression");
            int choice = 0;
            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    StudentTest studentTest = new StudentTest();
                    studentTest.Test();
                    break;
                case 2:
                    AddressBook addressBook = new AddressBook();
                    addressBook.operate();
                    break;
                case 3:
                    InventoryManager manager = new InventoryManager();
                    manager.Test();
                    break;
                case 4:
                    StockPortfolio portfolio = new StockPortfolio();
                    portfolio.Test();
                    break;
                case 5:
                    CommercialDataProcessing dataProcessing = new CommercialDataProcessing();
                    dataProcessing.Test();
                    break;
                case 6:
                    DeckOfCards deck = new DeckOfCards();
                    deck.Initialize();
                    break;
                case 7:
                    RegularExpression regularExpression = new RegularExpression();
                    regularExpression.checkExpression();
                    break;
                default:
                    Console.WriteLine("Invalid Input!!!");
                    break;
            }
        }
    }
}