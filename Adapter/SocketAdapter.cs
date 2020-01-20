//-----------------------------------------------------------------------
// <copyright file="SocketAdapter.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    /// <summary>
    /// The 'Adapter' Class
    /// </summary>
    /// <seealso cref="Design_Pattern.Socket" />
    /// <seealso cref="Design_Pattern.ISocketAdapter" />
    public class SocketAdapter : Socket, ISocketAdapter
    {
        /// <summary>
        /// Get 120 the volt.
        /// </summary>
        /// <returns>
        /// It returns 120 Volts
        /// </returns>
        public Volt Get120Volt()
        {
            return this.GetVolt();
        }

        /// <summary>
        /// Get 12 the volt.
        /// </summary>
        /// <returns>
        /// It returns 12 Volts
        /// </returns>
        public Volt Get12Volt()
        {
            Volt v = GetVolt();
            return this.ConvertVolt(v, 10);
        }

        /// <summary>
        /// Get 3 the volt.
        /// </summary>
        /// <returns>
        /// It returns 3 Volts
        /// </returns>
        public Volt Get3Volt()
        {
            Volt v = GetVolt();
            return this.ConvertVolt(v, 40);
        }

        /// <summary>
        /// Converts the volt.
        /// </summary>
        /// <param name="v">The v.</param>
        /// <param name="i">The i.</param>
        /// <returns>It return Volt</returns>
        private Volt ConvertVolt(Volt v, int i)
        {
            return new Volt(v.GetVolts() / i);
        }
    }
}