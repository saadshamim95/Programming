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

        public string AnalyseMood()
        {
            try
            {
                if (message == "I am in Sad Mood")
                {
                    return "SAD";
                }

                if (message == null)
                {
                    return "HAPPY";
                }

                return "HAPPY";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}