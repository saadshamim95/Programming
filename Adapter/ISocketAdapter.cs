//-----------------------------------------------------------------------
// <copyright file="ISocketAdapter.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    /// <summary>
    /// The 'ISocketAdapter' Target Interface
    /// </summary>
    public interface ISocketAdapter
    {
        /// <summary>
        /// Get 120 the volt.
        /// </summary>
        /// <returns>It returns 120 Volts</returns>
        public Volt Get120Volt();

        /// <summary>
        /// Get 12 the volt.
        /// </summary>
        /// <returns>It returns 12 Volts</returns>
        public Volt Get12Volt();

        /// <summary>
        /// Get 3 the volt.
        /// </summary>
        /// <returns>It returns 3 Volts</returns>
        public Volt Get3Volt();
    }
}