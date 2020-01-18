//-----------------------------------------------------------------------
// <copyright file="ThreadSafeSingleton.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    using System;

    /// <summary>
    /// Class for ThreadSafe
    /// </summary>
    public class ThreadSafeSingleton
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static ThreadSafeSingleton instance;

        /// <summary>
        /// The lock this
        /// </summary>
        private static object lockThis = new object();

        /// <summary>
        /// Prevents a default instance of the <see cref="ThreadSafeSingleton"/> class from being created.
        /// </summary>
        private ThreadSafeSingleton()
        {
            Console.WriteLine("Instance created with Thread Safe!!!");
        }
                
        /// <summary>
        /// Gets the get instance.
        /// </summary>
        /// <value>
        /// The instance
        /// </value>
        public static ThreadSafeSingleton GetInstance
        {
            get 
            {
                lock (lockThis)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingleton();
                    }

                    return instance;
                }
            }           
        }                
    }
}