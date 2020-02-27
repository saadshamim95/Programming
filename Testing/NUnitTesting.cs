//-----------------------------------------------------------------------
// <copyright file="NUnitTesting.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Testing
{
    using MoodAnalyser;
    using NUnit.Framework;

    /// <summary>
    /// Class for Testing
    /// </summary>
    [TestFixture]
    public class NUnitTesting
    {
        /// <summary>
        /// The Setup
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Given the sad message when analyze return sad.
        /// </summary>
        [Test]
        public void GivenSadMessage_WhenAnalyse_ReturnSad()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am in Sad Mood");
            string actual = moodAnalyzer.AnalyseMood();
            Assert.AreEqual("SAD", actual);
        }

        /// <summary>
        /// Given any message when analyze return happy.
        /// </summary>
        [Test]
        public void GivenAnyMessage_WhenAnalyse_ReturnHappy()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am in Happy Mood");
            string actual = moodAnalyzer.AnalyseMood();
            Assert.AreEqual("HAPPY", actual);
        }

        /// <summary>
        /// Given the null message when analyze return null.
        /// </summary>
        [Test]
        public void GivenNullMessage_WhenAnalyse_ReturnNull()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(null);
            string actual = moodAnalyzer.AnalyseMood();
            Assert.AreEqual("NULL", actual);
        }

        /// <summary>
        /// Given the empty message when analyze return empty.
        /// </summary>
        [Test]
        public void GivenEmptyMessage_WhenAnalyse_ReturnEmpty()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(string.Empty);
            string actual = moodAnalyzer.AnalyseMood();
            Assert.AreEqual("EMPTY", actual);
        }

        /// <summary>
        /// Given the mood analyzer class name when analyze return mood analyzer object.
        /// </summary>
        [Test]
        public void GivenMoodAnalyserClassName_WhenAnalyse_ReturnMoodAnalyserObject()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            Assert.IsTrue(moodAnalyzer.Equals(moodAnalyzer));
        }

        /// <summary>
        /// Given the class name improper when analyze return mood analysis exception.
        /// </summary>
        [Test]
        public void GivenClassNameImproper_WhenAnalyse_ReturnMoodAnalysisException()
        {
            string exceptionMessage = MoodAnalyserReflector.CreateObject("Test").ToString();
            Assert.AreEqual("No Such Class Error", exceptionMessage);
        }

        /// <summary>
        /// Given the mood analyzer proper through constructor when analyze return mood analyzer object.
        /// </summary>
        [Test]
        public void GivenMoodAnalyserProperThroughConstructor_WhenAnalyse_ReturnMoodAnalyserObject()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("Hello");
            Assert.IsTrue(moodAnalyzer.Equals(moodAnalyzer));
        }

        /// <summary>
        /// Given the class name improper through constructor when analyze return mood analysis exception.
        /// </summary>
        [Test]
        public void GivenClassNameImproperThroughConstructor_WhenAnalyse_ReturnMoodAnalysisException()
        {
            string exceptionMessage = MoodAnalyserReflector.CreateObject("Test", "Hello").ToString();
            Assert.AreEqual("No Such Class Error", exceptionMessage);
        }

        /// <summary>
        /// Given the happy message using reflection when analyze return happy mood.
        /// </summary>
        [Test]
        public void GivenHappyMessageUsingReflection_WhenAnalyse_ReturnHappyMood()
        {
            MoodAnalyzer moodAnalyzer = (MoodAnalyzer)MoodAnalyserReflector.CreateObject("MoodAnalyzer", "Happy");
            string actual = moodAnalyzer.GetType().GetMethod("AnalyseMood").Invoke(moodAnalyzer, null).ToString();
            Assert.AreEqual("HAPPY", actual);
        }

        /// <summary>
        /// Given the happy message when improper method when analyze return mood analysis exception.
        /// </summary>
        [Test]
        public void GivenHappyMessageWhenImproperMethod_WhenAnalyse_ReturnMoodAnalysisException()
        {
            string actual = MoodAnalyserReflector.MethodCheck("analyseMood");
            Assert.AreEqual("No Such Method Error", actual);
        }

        [Test]
        public void SetHappyMessageWithReflector_WhenAnalyse_ReturnHappy()
        {
            MoodAnalyserReflector moodAnalyserReflector = (MoodAnalyserReflector)MoodAnalyserReflector.CreateObject("MoodAnalyserReflector");
            string[] parameters = new string[1];
            parameters[0] = "Happy";
            string actual = moodAnalyserReflector.GetType().GetMethod("SetField").Invoke(moodAnalyserReflector, parameters).ToString();
            Assert.AreEqual("Happy", actual);
        }
    }
}