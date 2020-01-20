//-----------------------------------------------------------------------
// <copyright file="AdapterMain.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    using System;

    /// <summary>
    /// The Adapter Class
    /// </summary>
    public class AdapterMain
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public void Test()
        {
            ISocketAdapter socketAdapter = new SocketAdapter();
            Volt v3 = this.GetVolt(socketAdapter, 3);
            Volt v12 = this.GetVolt(socketAdapter, 12);
            Volt v120 = this.GetVolt(socketAdapter, 120);
            Console.WriteLine("v3 volts using adapter: " + v3.GetVolts() + "V");
            Console.WriteLine("v12 volts using adapter: " + v12.GetVolts() + "V");
            Console.WriteLine("v120 volts using adapter: " + v120.GetVolts() + "V");
        }

        /// <summary>
        /// Gets the volt.
        /// </summary>
        /// <param name="socketAdapter">The socket adapter.</param>
        /// <param name="i">The i.</param>
        /// <returns>It returns volt</returns>
        private Volt GetVolt(ISocketAdapter socketAdapter, int i)
        {
            switch (i)
            {
                case 3:
                    return socketAdapter.Get3Volt();
                case 12:
                    return socketAdapter.Get12Volt();
                case 120:
                    return socketAdapter.Get120Volt();
                default:
                    return socketAdapter.Get120Volt();
            }
        }
    }
}