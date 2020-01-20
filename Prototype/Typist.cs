//-----------------------------------------------------------------------
// <copyright file="Typist.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    /// <summary>
    /// The 'ConcretePrototype' Class
    /// </summary>
    /// <seealso cref="Design_Pattern.IEmployee" />
    public class Typist : IEmployee
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the role.
        /// </summary>
        /// <value>
        /// The role.
        /// </value>
        public string Role { get; set; }

        /// <summary>
        /// Gets or sets the words per minute.
        /// </summary>
        /// <value>
        /// The words per minute.
        /// </value>
        public int WordsPerMinute { get; set; }

        /// <summary>
        /// Clones this instance.
        /// </summary>
        /// <returns>
        /// It returns IEmployee type
        /// </returns>
        public IEmployee Clone()
        {
            return (IEmployee)MemberwiseClone();
        }

        /// <summary>
        /// Gets the details.
        /// </summary>
        /// <returns>
        /// It returns string
        /// </returns>
        public string GetDetails()
        {
            return string.Format("{0} - {1} - {2}", this.Name, this.Role, this.WordsPerMinute);
        }
    }
}