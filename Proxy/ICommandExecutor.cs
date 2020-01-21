//-----------------------------------------------------------------------
// <copyright file="ICommandExecutor.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    /// <summary>
    /// The 'Subject' Interface
    /// </summary>
    public interface ICommandExecutor
    {
        /// <summary>
        /// Runs the command.
        /// </summary>
        /// <param name="cmd">The command.</param>
        public void RunCommand(string cmd);
    }
}