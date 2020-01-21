//-----------------------------------------------------------------------
// <copyright file="IObserver.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    /// <summary>
    /// Observer Interface
    /// </summary>
    public interface IObserver
    {
        /// <summary>
        /// Updates this instance.
        /// </summary>
        public void Update();

        /// <summary>
        /// Sets the subject.
        /// </summary>
        /// <param name="subject">The subject.</param>
        public void SetSubject(ISubject subject);
    }
}