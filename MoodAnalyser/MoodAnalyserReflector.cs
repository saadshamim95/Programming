//-----------------------------------------------------------------------
// <copyright file="MoodAnalyserReflector.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace MoodAnalyser
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Class for creating object using reflection.
    /// </summary>
    public class MoodAnalyserReflector
    {
        /// <summary>
        /// The check
        /// </summary>
        public static string check; 

        /// <summary>
        /// Creates the object.
        /// </summary>
        /// <param name="className">The className.</param>
        /// <returns>It returns object</returns>
        /// <exception cref="MoodAnalysisException">No Such Class Error</exception>
        public static object CreateObject(string className)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyser." + className);
                if (type != null)
                {
                    object obj = Activator.CreateInstance(type);
                    return obj;
                }

                throw new MoodAnalysisException("No Such Class Error", MoodAnalysisException.TypeOfException.NO_SUCH_CLASS_ERROR);
            }
            catch (MoodAnalysisException exception)
            {
                return exception.Message;
            }
        }

        /// <summary>
        /// Creates the object.
        /// </summary>
        /// <param name="className">The className.</param>
        /// <param name="message">The message.</param>
        /// <returns>It returns object</returns>
        /// <exception cref="MoodAnalysisException">No Such Class Error</exception>
        public static object CreateObject(string className, string message)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyser." + className);
                if (type != null)
                {
                    object[] argument = { message };
                    object obj = Activator.CreateInstance(type, argument);
                    return obj;
                }

                throw new MoodAnalysisException("No Such Class Error", MoodAnalysisException.TypeOfException.NO_SUCH_CLASS_ERROR);
            }
            catch (MoodAnalysisException exception)
            {
                return exception.Message;
            }
        }

        /// <summary>
        /// Methods the check.
        /// </summary>
        /// <param name="methodName">Name of the method.</param>
        /// <returns>It returns method name if method exist</returns>
        /// <exception cref="MoodAnalysisException">No Such Method Error</exception>
        public static string MethodCheck(string methodName)
        {
            MoodAnalyzer moodAnalyzer = (MoodAnalyzer)MoodAnalyserReflector.CreateObject("MoodAnalyzer", "Happy");
            MethodInfo methodInfos = moodAnalyzer.GetType().GetMethod(methodName);
            try
            {
                if (methodInfos == null)
                {
                    throw new MoodAnalysisException("No Such Method Error", MoodAnalysisException.TypeOfException.NO_SUCH_METHOD_ERROR);
                }

                return methodName;
            }
            catch (MoodAnalysisException exception)
            {
                return exception.Message;
            }
        }

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="message">The message.</param>
        /// <returns>It returns message if given proper fieldName</returns>
        /// <exception cref="MoodAnalyser.MoodAnalysisException">No Such Field Error</exception>
        public string SetField(string fieldName, string message)
        {
            try 
            {
                if (fieldName == "check")
                {
                    check = message;
                    if (message == null)
                    {
                        throw new MoodAnalysisException("Null", MoodAnalysisException.TypeOfException.NULL);
                    }

                    FieldInfo fieldInfo = typeof(MoodAnalyserReflector).GetField("check");
                    return fieldInfo.GetValue(null).ToString();
                }

                throw new MoodAnalysisException("No Such Field Error", MoodAnalysisException.TypeOfException.NO_SUCH_FIELD_ERROR);
            }
            catch (MoodAnalysisException exception)
            {
                return exception.Message;
            }
        }
    }
}