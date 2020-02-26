using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyzer
    {
        private string message;

        public MoodAnalyzer()
        {
        }

        public MoodAnalyzer(string message)
        {
            this.message = message;
        }

        public override bool Equals(object obj)
        {
            //object moodAnalyserFactory = MoodAnalyserFactory.CreateObject("MoodAnalyzer");
            object moodAnalyserFactory = MoodAnalyserReflector.CreateObject("MoodAnalyzer", "Hello");
            if (moodAnalyserFactory.GetType() == obj.GetType())
            {
                return true;
            }

            return false;
        }

        public string AnalyseMood()
        {
            try
            {
                if (message == "I am in Sad Mood")
                {
                    return "SAD";
                }
                
                if (message == string.Empty)
                {
                    throw new MoodAnalysisException("EMPTY", MoodAnalysisException.typeOfException.EMPTY);
                }

                if (message == null)
                {
                    throw new MoodAnalysisException("NULL", MoodAnalysisException.typeOfException.NULL);
                }
            }
            catch (MoodAnalysisException ex)
            {
                return ex.Message;
            }

            return "HAPPY";
        }
    }
}