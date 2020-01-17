//-----------------------------------------------------------------------
// <copyright file="StockAccount.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Object_Oriented
{
    using System;

    /// <summary>
    /// Class for Stock Account
    /// </summary>
    public class StockAccount
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public void Test()
        {
            Console.WriteLine("1: Create New Account");
            Console.WriteLine("2: Buy Share");
            Console.WriteLine("3: Sell Share");
            Console.WriteLine("4: Print Shares of Particular Account");
            Console.WriteLine("5: Display Overall Company Share");
            Console.WriteLine("6: Exit");
            Console.WriteLine();
            Console.Write("Enter your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            string account;
            switch (choice)
            {
                case 1:
                    Console.Write("Enter Account Name: ");
                    account = Console.ReadLine();
                    CreateAccount.Create(account);
                    Console.WriteLine();
                    this.Test();
                    break;
                case 2:
                    Console.Write("Enter Account Name: ");
                    account = Console.ReadLine();
                    BuyStock buyStock = new BuyStock();
                    buyStock.BuyShares(account);
                    Console.WriteLine();
                    this.Test();
                    break;
                case 3:
                    Console.Write("Enter Account Name: ");
                    account = Console.ReadLine();
                    SellStock sellStock = new SellStock();
                    sellStock.SellShares(account);
                    Console.WriteLine();
                    this.Test();
                    break;
                case 4:
                    Console.Write("Enter Account Name: ");
                    account = Console.ReadLine();
                    Display display = new Display();
                    display.DisplayShares(account);
                    Console.WriteLine();
                    this.Test();
                    break;
                case 5:
                    Display displayCompany = new Display();
                    displayCompany.DisplayShares("Company");
                    Console.WriteLine();
                    this.Test();
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine("Invalid Input!!!\n");
                    this.Test();
                    break;
            }
        }
    }
}