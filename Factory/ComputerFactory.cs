//-----------------------------------------------------------------------
// <copyright file="ComputerFactory.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    /// <summary>
    /// The Creator Abstract Class
    /// </summary>
    public abstract class ComputerFactory
    {
        /// <summary>
        /// Gets the device.
        /// </summary>
        /// <param name="device">The device.</param>
        /// <returns>It returns nothing</returns>
        public abstract IFactory GetDevice(string device);
    }
}