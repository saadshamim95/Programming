//-----------------------------------------------------------------------
// <copyright file="CommercialDataProcessing.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Object_Oriented
{
    using System;

    /// <summary>
    /// Class for Commercial Data Processing
    /// </summary>
    public class CommercialDataProcessing
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public void Test()
        {
            Console.WriteLine("1: Create New Account");
            Console.WriteLine("2: Buy New Share");
            Console.WriteLine("3: Buy Existing Share");
            Console.WriteLine("4: Sell Share");
            Console.WriteLine("5: Print Shares of Particular Account");
            Console.WriteLine("6: Display Overall Company Share");
            Console.WriteLine("7: Exit");
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
                    Console.WriteLine("Account Successfully Created!!!");
                    Console.WriteLine();
                    Test();
                    break;
                case 2:
                    Console.Write("Enter Account Name: ");
                    account = Console.ReadLine();
                    BuyNewStock buyNewStock = new BuyNewStock();
                    buyNewStock.BuyStock(account);
                    Console.WriteLine();
                    Test();
                    break;
                case 3:
                    Console.Write("Enter the Account name: ");
                    account = Console.ReadLine();
                    BuyExistingStock buyExistingStock = new BuyExistingStock();
                    buyExistingStock.BuyStock(account);
                    Console.WriteLine();
                    Test();
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                default:
                    Console.WriteLine("Invalid Input!!!\n");
                    break;
            }
        }
    }
}