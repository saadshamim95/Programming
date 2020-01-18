//-----------------------------------------------------------------------
// <copyright file="LazyInitialization.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    /// <summary>
    /// Class for Lazy initialization of instance
    /// </summary>
    public class LazyInitialization
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static LazyInitialization instance;

        /// <summary>
        /// Prevents a default instance of the <see cref="LazyInitialization"/> class from being created.
        /// </summary>
        private LazyInitialization()
        { 
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <returns>Instance of a Singleton class</returns>
        public static LazyInitialization GetInstance()
        {
            if (instance == null) 
            {
                instance = new LazyInitialization();
            }

            return instance;
        }
    }
}