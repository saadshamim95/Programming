//-----------------------------------------------------------------------
// <copyright file="ISubject.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    /// <summary>
    /// Subject Interface
    /// </summary>
    public interface ISubject
    {
        /// <summary>
        /// Registers the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        public void Register(IObserver observer);

        /// <summary>
        /// Unregisters the specified observer.
        /// </summary>
        /// <param name="observer">The observer.</param>
        public void Unregister(IObserver observer);

        /// <summary>
        /// Notifies the observers.
        /// </summary>
        public void NotifyObservers();

        /// <summary>
        /// Gets the update.
        /// </summary>
        /// <param name="observer">The observer.</param>
        /// <returns>It returns object</returns>
        public object GetUpdate(IObserver observer);
    }
}