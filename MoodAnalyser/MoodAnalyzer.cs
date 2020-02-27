//-----------------------------------------------------------------------
// <copyright file="MoodAnalyzer.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace MoodAnalyser
{
    /// <summary>
    /// Class MoodAnalyzer
    /// </summary>
    public class MoodAnalyzer
    {
        /// <summary>
        /// The message
        /// </summary>
        private string message;

        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalyzer"/> class.
        /// </summary>
        public MoodAnalyzer()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalyzer"/> class.
        /// </summary>
        /// <param name="message">The message.</param>
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            ////object moodAnalyserFactory = MoodAnalyserFactory.CreateObject("MoodAnalyzer");
            object moodAnalyserFactory = MoodAnalyserReflector.CreateObject("MoodAnalyzer", "Hello");
            if (moodAnalyserFactory.GetType() == obj.GetType())
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Analyses the mood.
        /// </summary>
        /// <returns>It return Sad if message contains Sad else Happy</returns>
        /// <exception cref="MoodAnalysisException">
        /// EMPTY
        /// or
        /// NULL
        /// </exception>
        public string AnalyseMood()
        {
            try
            {
                if (this.message == "I am in Sad Mood")
                {
                    return "SAD";
                }
                
                if (this.message == string.Empty)
                {
                    throw new MoodAnalysisException("EMPTY", MoodAnalysisException.TypeOfException.EMPTY);
                }

                if (this.message == null)
                {
                    throw new MoodAnalysisException("NULL", MoodAnalysisException.TypeOfException.NULL);
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