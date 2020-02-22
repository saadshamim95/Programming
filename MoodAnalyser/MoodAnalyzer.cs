using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyzer
    {
        public string AnalyseMood(string mood)
        {
            if (mood == "I am in Sad Mood")
            { 
                return "SAD"; 
            }
            return "HAPPY";
        }
    }
}