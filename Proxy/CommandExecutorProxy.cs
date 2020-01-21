//-----------------------------------------------------------------------
// <copyright file="CommandExecutorProxy.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    using System;

    /// <summary>
    /// The 'Proxy' Command Executor Proxy Class
    /// </summary>
    /// <seealso cref="Design_Pattern.ICommandExecutor" />
    public class CommandExecutorProxy : ICommandExecutor
    {
        /// <summary>
        /// The is admin
        /// </summary>
        private bool isAdmin = false;

        /// <summary>
        /// The executor
        /// </summary>
        private ICommandExecutor executor;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandExecutorProxy"/> class.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <param name="pwd">The password.</param>
        public CommandExecutorProxy(string user, string pwd)
        {
            if ("Saad".Equals(user) && "saad@123".Equals(pwd))
            {
                this.isAdmin = true;
            }

            this.executor = new CommandExecutor();
        }

        /// <summary>
        /// Runs the command.
        /// </summary>
        /// <param name="cmd">The command.</param>
        /// <exception cref="Exception">rm command is not valid for non-admin users</exception>
        public void RunCommand(string cmd)
        {
            if (this.isAdmin)
            {
                this.executor.RunCommand(cmd);
            }
            else
            {
                if (cmd.Trim().StartsWith("rm"))
                {
                    throw new Exception("rm command is not valid for non-admin users");
                }
                else
                {
                    this.executor.RunCommand(cmd);
                }
            }
        }
    }
}