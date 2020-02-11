//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace LearningLogger
{
    using System;
    using log4net;
    
    /// <summary>
    /// Class for testing Logger
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The log
        /// </summary>
        private static readonly ILog Log = LogHelper.GetLogger();

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Log.Error("This is my error message");
            Console.ReadLine();
        }
    }
}