using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyserFactory
    {
        public static object CreateObject(string classname)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyser." + classname);
                if (type != null)
                {
                    object obj = Activator.CreateInstance(type);
                    return obj;
                }

                throw new MoodAnalysisException("No Such Class Error", MoodAnalysisException.typeOfException.NO_SUCH_CLASS_ERROR);
            }
            catch (MoodAnalysisException Ex)
            {
                return Ex.Message;
            }            
        }
    }
}