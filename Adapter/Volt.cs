//-----------------------------------------------------------------------
// <copyright file="Volt.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    /// <summary>
    /// The class Volt
    /// </summary>
    public class Volt
    {
        /// <summary>
        /// The volts
        /// </summary>
        private int volts;

        /// <summary>
        /// Initializes a new instance of the <see cref="Volt"/> class.
        /// </summary>
        /// <param name="volt">The volt.</param>
        public Volt(int volt)
        {
            this.volts = volt;
        }

        /// <summary>
        /// Gets the volts.
        /// </summary>
        /// <returns>It returns Volts</returns>
        public int GetVolts()
        {
            return this.volts;
        }

        /// <summary>
        /// Sets the volts.
        /// </summary>
        /// <param name="volts">The volts.</param>
        public void SetVolts(int volts)
        {
            this.volts = volts;
        }
    }
}