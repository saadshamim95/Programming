//-----------------------------------------------------------------------
// <copyright file="LogHelper.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace LearningLogger
{
    using System.Runtime.CompilerServices;

    /// <summary>
    /// Class LogHelper
    /// </summary>
    public class LogHelper
    {
        /// <summary>
        /// Gets the logger.
        /// </summary>
        /// <param name="filename">The filename.</param>
        /// <returns>returns file path</returns>
        public static log4net.ILog GetLogger([CallerFilePath]string filename = "")
        {
            return log4net.LogManager.GetLogger(filename);
        }
    }
}