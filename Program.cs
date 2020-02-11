using log4net;
using System;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace LearningLogger
{
    class Program
    {
        private static readonly ILog log = LogHelper.GetLogger(); //LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            log.Error("This is my error message");
            Console.ReadLine();
        }
    }
}