//-----------------------------------------------------------------------
// <copyright file="LazyInitializationSingleton.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    using System;

    /// <summary>
    /// Class for Lazy Initialization
    /// </summary>
    public class LazyInitializationSingleton
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static LazyInitializationSingleton instance;

        /// <summary>
        /// Prevents a default instance of the <see cref="LazyInitializationSingleton"/> class from being created.
        /// </summary>
        private LazyInitializationSingleton()
        {
            Console.WriteLine("Instance created with Lazy Initialization!!!");
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <returns>Instance of a Singleton class</returns>
        public static LazyInitializationSingleton GetInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LazyInitializationSingleton();
                }

                return instance;
            }           
        }
    }
}