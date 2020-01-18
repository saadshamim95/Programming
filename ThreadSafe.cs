using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Pattern
{
    public class ThreadSafe
    {
        private static ThreadSafe instance;

        private ThreadSafe()
        { 
        }

        /*public static ThreadSafe GetInstance()
        {
            lock () 
            { 
            
            }
            if (instance == null)
            {
                instance = new ThreadSafe();
            }

            return instance;
        }*/
    }
}
