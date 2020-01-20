//-----------------------------------------------------------------------
// <copyright file="Computer.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    using System;

    /// <summary>
    /// A 'ConcreteCreator' Class
    /// </summary>
    /// <seealso cref="Design_Pattern.ComputerFactory" />
    public class Computer : ComputerFactory
    {
        /// <summary>
        /// Gets the device.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <returns>It returns nothing</returns>
        /// <exception cref="ApplicationException">Throws Application Exception</exception>
        public override IFactory GetDevice(string device)
        {
            switch (device.ToLower())
            {
                case "pc":
                    return new PC();
                case "server":
                    return new Server();
                default:
                    throw new ApplicationException(string.Format("'{0}' cannot be created!!!", device));
            }
        }
    }
}