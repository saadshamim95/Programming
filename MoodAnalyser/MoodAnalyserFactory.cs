using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyserFactory
    {
        public static object CreateObject(string classname)
        {
            Type type = Type.GetType("MoodAnalyser." + classname);
            object obj = Activator.CreateInstance(type);
            return obj;
        }
    }
}