//-----------------------------------------------------------------------
// <copyright file="ProxyMain.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    using System;

    /// <summary>
    /// Class for testing Proxy Design Pattern
    /// </summary>
    public class ProxyMain
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public void Test()
        {
            ICommandExecutor executor = new CommandExecutorProxy("Saad", "wrong_pwd");
            try
            {
                executor.RunCommand("ls -ltr");
                executor.RunCommand("rm -rf abc.pdf");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Message: " + e.Message);
            }
        }
    }
}