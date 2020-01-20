//-----------------------------------------------------------------------
// <copyright file="PC.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    using System;

    /// <summary>
    /// A 'ConcreteProduct' PC Class
    /// </summary>
    /// <seealso cref="Design_Pattern.IFactory" />
    public class PC : IFactory
    {
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <param name="ram">The ram.</param>
        /// <param name="hdd">The HDD.</param>
        /// <param name="cpu">The cpu.</param>
        public void GetDetails(string ram, string hdd, string cpu)
        {
            Console.WriteLine("PC:");
            Console.WriteLine("RAM: " + ram);
            Console.WriteLine("HDD: " + hdd);
            Console.WriteLine("CPU: " + cpu);
        }
    }
}