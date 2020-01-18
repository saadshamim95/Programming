//-----------------------------------------------------------------------
// <copyright file="EagerInitialization.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    using System;

    /// <summary>
    /// Class for Eager Initialization of instance
    /// </summary>
    public class EagerInitialization
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static EagerInitialization instance = new EagerInitialization();

        /// <summary>
        /// Prevents a default instance of the <see cref="EagerInitialization"/> class from being created.
        /// </summary>
        private EagerInitialization()
        {
            Console.WriteLine("Object Created with Eager Initialization!!!");
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <returns>Instance of a Singleton class</returns>
        public static EagerInitialization GetInstance
        {
            get
            {
                return instance;
            }           
        }
    }
}