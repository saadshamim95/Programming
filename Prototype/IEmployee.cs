//-----------------------------------------------------------------------
// <copyright file="IEmployee.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    /// <summary>
    /// The 'Prototype' Interface
    /// </summary>
    public interface IEmployee
    {
        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>It returns IEmployee type</returns>
        public IEmployee Clone();

        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <returns>It returns string</returns>
        public string GetDetails();
    }
}