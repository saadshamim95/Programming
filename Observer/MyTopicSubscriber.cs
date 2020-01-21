//-----------------------------------------------------------------------
// <copyright file="MyTopicSubscriber.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    using System;

    /// <summary>
    /// Subscriber Class
    /// </summary>
    /// <seealso cref="Design_Pattern.IObserver" />
    public class MyTopicSubscriber : IObserver
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The topic
        /// </summary>
        private ISubject topic;

        /// <summary>
        /// Initializes a new instance of the <see cref="MyTopicSubscriber"/> class.
        /// </summary>
        /// <param name="nm">The nm.</param>
        public MyTopicSubscriber(string nm)
        {
            this.name = nm;
        }

        /// <summary>
        /// Sets the subject.
        /// </summary>
        /// <param name="subject">The subject.</param>
        public void SetSubject(ISubject subject)
        {
            this.topic = subject;
        }

        /// <summary>
        /// Updates this instance.
        /// </summary>
        public void Update()
        {
            string msg = (string)this.topic.GetUpdate(this);
            if (msg == null)
            {
                Console.WriteLine("No new message");
            }
            else 
            {
                Console.WriteLine(this.name + ":: Consuming message :: " + msg);
            }
        }
    }
}