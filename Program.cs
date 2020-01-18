using System;

namespace Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EagerInitialization eagerInitialization = EagerInitialization.GetInstance;
            StaticBlockInitialization staticBlockInitialization = StaticBlockInitialization.GetInstance;
            LazyInitialization lazyInitialization = LazyInitialization.GetInstance;
        }
    }
}