//-----------------------------------------------------------------------
// <copyright file="EagerInitializationSingleton.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    using System;

    /// <summary>
    /// Class for Eager Initialization
    /// </summary>
    public class EagerInitializationSingleton
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static EagerInitializationSingleton instance = new EagerInitializationSingleton();

        /// <summary>
        /// Prevents a default instance of the <see cref="EagerInitializationSingleton"/> class from being created.
        /// </summary>
        private EagerInitializationSingleton()
        {
            Console.WriteLine("Instance created with Eager Initialization!!!");
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <returns>Instance of a Singleton class</returns>
        public static EagerInitializationSingleton GetInstance
        {
            get
            {
                return instance;
            }           
        }
    }
}