using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    //[Serializable]
    public class MoodAnalysisException : Exception
    {
        public MoodAnalysisException()
        { 
        }

        public MoodAnalysisException(string message, typeOfException type)
        {
            this.message = message;
            this.type = type;
        }

        public enum typeOfException
        {
            EMPTY,
            NULL,
            NO_SUCH_CLASS_ERROR,
        }

        public typeOfException type;
        public string message;

        //public MoodAnalysisException() : base() { }

        //public MoodAnalysisException(string message) : base(message) 
        //{
        //    this.message = message;
        //}

        //public MoodAnalysisException(string message, Exception ex) : base(message, ex) 
        //{
        //    this.message = message;   
        //}

        

        public override string Message
        {
            get
            {
                return this.message;
            }
        }
    }
}