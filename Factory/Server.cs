//-----------------------------------------------------------------------
// <copyright file="Server.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    using System;

    /// <summary>
    /// A 'ConcreteProduct' Server Class
    /// </summary>
    /// <seealso cref="Design_Pattern.IFactory" />
    public class Server : IFactory
    {
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <param name="ram">The ram.</param>
        /// <param name="hdd">The HDD.</param>
        /// <param name="cpu">The cpu.</param>
        public void GetDetails(string ram, string hdd, string cpu)
        {
            Console.WriteLine("Server:");
            Console.WriteLine("RAM: " + ram);
            Console.WriteLine("HDD: " + hdd);
            Console.WriteLine("CPU: " + cpu);
        }
    }
}