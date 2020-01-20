//-----------------------------------------------------------------------
// <copyright file="Developer.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    /// <summary>
    /// A 'ConcretePrototype' Class
    /// </summary>
    /// <seealso cref="Design_Pattern.IEmployee" />
    public class Developer : IEmployee
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
        /// Gets or sets the preferred language.
        /// </summary>
        /// <value>
        /// The preferred language.
        /// </value>
        public string PreferredLanguage { get; set; }

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
            return string.Format("{0} - {1} - {2}", this.Name, this.Role, this.PreferredLanguage);
        }
    }
}