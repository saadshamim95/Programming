//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    using System;

    /// <summary>
    /// Main class Program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("1: Singleton DP");
            Console.WriteLine("2: Factory DP");
            Console.Write("Enter you choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    SingletonMain singletonMain = new SingletonMain();
                    singletonMain.CreateObject();
                    break;
                case 2:
                    FactoryProgram factoryProgram = new FactoryProgram();
                    factoryProgram.Test();
                    break;
                default:
                    Console.WriteLine("Invalid Input!!!");
                    break;
            }            
        }
    }
}