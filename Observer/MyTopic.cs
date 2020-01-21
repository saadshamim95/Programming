//-----------------------------------------------------------------------
// <copyright file="MyTopic.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Design_Pattern
{
    public class MyTopic : ISubject
    {
        private List<IObserver> observers;
        private string message;
        private bool changed;
        private object MUTEX = new object();

        public MyTopic()
        {
            this.observers = new List<IObserver>();
        }

        public object GetUpdate(IObserver observer)
        {
            return this.message;
        }

        public void NotifyObservers()
        {
            List<IObserver> observersLocal = null;
            lock (MUTEX)
            {
                if (!changed)
                    return;
                observersLocal=new List<IObserver>(this.observers);
                this.changed = false;
            }
            foreach (IObserver obj in observersLocal)
            {
                obj.Update();
            }
        }

        public void Register(IObserver observer)
        {
            if (observer == null)
            {
                throw new NullReferenceException("Null Observer"); 
            }
            lock (MUTEX)
            {
                if (!observers.Contains(observer))
                {
                    observers.Add(observer);
                }
            }
        }

        public void Unregister(IObserver observer)
        {
            lock (MUTEX)
            {
                observers.Remove(observer);
            }
        }

        public void PostMessage(string msg)
        {
            Console.WriteLine("Message posted to Topic: " + msg);
            this.message = msg;
            this.changed = true;
            NotifyObservers();
        }
    }
}