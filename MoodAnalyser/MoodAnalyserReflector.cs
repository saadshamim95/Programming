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

        public static string SetField(string message)
        {
            check = message;
            FieldInfo fieldInfo = typeof(MoodAnalyserReflector).GetField("check");
            return fieldInfo.GetValue(null).ToString();
        }
    }
}