//-----------------------------------------------------------------------
// <copyright file="ObserverMain.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    /// <summary>
    /// Class for testing Observer Design pattern
    /// </summary>
    public class ObserverMain
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public void Test()
        {
            MyTopic topic = new MyTopic();

            IObserver obj1 = new MyTopicSubscriber("Obj1");
            IObserver obj2 = new MyTopicSubscriber("Obj2");
            IObserver obj3 = new MyTopicSubscriber("Obj3");

            topic.Register(obj1);
            topic.Register(obj2);
            topic.Register(obj3);

            obj1.SetSubject(topic);
            obj2.SetSubject(topic);
            obj3.SetSubject(topic);

            obj1.Update();

            topic.PostMessage("New Message received!!!");
        }
    }
}