//-----------------------------------------------------------------------
// <copyright file="IFactory.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    /// <summary>
    /// The 'Product' Interface
    /// </summary>
    public interface IFactory
    {
        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <param name="ram">The ram.</param>
        /// <param name="hdd">The HDD.</param>
        /// <param name="cpu">The cpu.</param>
        public void GetDetails(string ram, string hdd, string cpu);
    }
}