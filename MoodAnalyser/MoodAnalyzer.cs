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
            if (message == "I am in Sad Mood")
            { 
                return "SAD"; 
            }

            return "HAPPY";
        }
    }
}