//-----------------------------------------------------------------------
// <copyright file="CommandExecutor.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    using System;

    /// <summary>
    /// The 'RealSubject' CommandExecutor Class
    /// </summary>
    /// <seealso cref="Design_Pattern.ICommandExecutor" />
    public class CommandExecutor : ICommandExecutor
    {
        /// <summary>
        /// Runs the command.
        /// </summary>
        /// <param name="cmd">The command.</param>
        public void RunCommand(string cmd)
        {
            Console.WriteLine("'" + cmd + "' command executed.");
        }
    }
}