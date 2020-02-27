//-----------------------------------------------------------------------
// <copyright file="MoodAnalysisException.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace MoodAnalyser
{
    using System;

    /// <summary>
    /// Class for custom exception
    /// </summary>
    /// <seealso cref="System.Exception" />
    public class MoodAnalysisException : Exception
    {
        /// <summary>
        /// The type
        /// </summary>
        private TypeOfException type;

        /// <summary>
        /// The message
        /// </summary>
        private string message;

        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalysisException"/> class.
        /// </summary>
        public MoodAnalysisException()
        { 
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalysisException"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="type">The type.</param>
        public MoodAnalysisException(string message, TypeOfException type)
        {
            this.message = message;
            this.type = type;
        }

        /// <summary>
        /// enum for Exception type
        /// </summary>
        public enum TypeOfException
        {
            /// <summary>
            /// The empty
            /// </summary>
            EMPTY,

            /// <summary>
            /// The null
            /// </summary>
            NULL,

            /// <summary>
            /// The no such class error
            /// </summary>
            NO_SUCH_CLASS_ERROR,

            /// <summary>
            /// The no such method error
            /// </summary>
            NO_SUCH_METHOD_ERROR,

            /// <summary>
            /// The no such field error
            /// </summary>
            NO_SUCH_FIELD_ERROR
        }

        /// <summary>
        /// Gets a message that describes the current exception.
        /// </summary>
        public override string Message
        {
            get
            {
                return this.message;
            }
        }
    }
}