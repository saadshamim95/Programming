namespace Design_Pattern
{
    /// <summary>
    /// Class for Singleton Design Pattern
    /// </summary>
    class SingletonMain
    {
        /// <summary>
        /// Creates the object.
        /// </summary>
        public void CreateObject() {
            /// <summary>
            /// The eager initialization
            /// </summary>
            EagerInitializationSingleton eagerInitialization = EagerInitializationSingleton.GetInstance;

            /// <summary>
            /// The lazy initialization
            /// </summary>
            LazyInitializationSingleton lazyInitialization = LazyInitializationSingleton.GetInstance;

            /// <summary>
            /// The thread safe
            /// </summary>
            ThreadSafeSingleton threadSafe = ThreadSafeSingleton.GetInstance;
        }
    }
}
