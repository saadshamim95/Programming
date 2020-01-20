//-----------------------------------------------------------------------
// <copyright file="Socket.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    /// <summary>
    /// The 'Adaptee' Class
    /// </summary>
    public class Socket
    {
        /// <summary>
        /// Gets the volt.
        /// </summary>
        /// <returns>It returns Volt</returns>
        public Volt GetVolt()
        {
            return new Volt(120);
        }
    }
}