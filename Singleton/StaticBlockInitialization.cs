//-----------------------------------------------------------------------
// <copyright file="StaticBlockInitialization.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    using System;

    /// <summary>
    /// Class for Static Block Initialization of instance
    /// </summary>
    public class StaticBlockInitialization
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static StaticBlockInitialization instance;

        /// <summary>
        /// Initializes static members of the <see cref="StaticBlockInitialization"/> class.
        /// </summary>
        static StaticBlockInitialization()
        {
            try
            {
                instance = new StaticBlockInitialization();
                Console.WriteLine("Instance Created with Static Block initialization!!!");
            }
            catch (Exception)
            {
                Console.WriteLine("Exception occurred in creating singleton instance");
            }
        }

        /// <summary>
        /// Prevents a default instance of the <see cref="StaticBlockInitialization"/> class from being created.
        /// </summary>
        private StaticBlockInitialization()
        {
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <returns>Instance of a Singleton class</returns>
        public static StaticBlockInitialization GetInstance
        {
            get
            {
                return instance;
            }
        }
    }
}