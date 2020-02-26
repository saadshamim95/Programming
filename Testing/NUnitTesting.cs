using MoodAnalyser;
using NUnit.Framework;

namespace Testing
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenSadMessage_WhenAnalyse_ReturnSad()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am in Sad Mood");
            string actual = moodAnalyzer.AnalyseMood();
            Assert.AreEqual("SAD", actual);
        }

        [Test]
        public void GivenAnyMessage_WhenAnalyse_ReturnHappy()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("I am in Happy Mood");
            string actual = moodAnalyzer.AnalyseMood();
            Assert.AreEqual("HAPPY", actual);
        }

        [Test]
        public void GivenNullMessage_WhenAnalyse_ReturnNull()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(null);
            string actual = moodAnalyzer.AnalyseMood();
            Assert.AreEqual("NULL", actual);
        }

        [Test]
        public void GivenEmptyMessage_WhenAnalyse_ReturnEmpty()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer(string.Empty);
            string actual = moodAnalyzer.AnalyseMood();
            Assert.AreEqual("EMPTY", actual);
        }

        [Test]
        public void GivenMoodAnalyserClassName_WhenAnalyse_ReturnMoodAnalyserObject()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            Assert.IsTrue(moodAnalyzer.Equals(moodAnalyzer));
        }

        [Test]
        public void GivenClassNameImproper_WhenAnalyse_ReturnMoodAnalysisException()
        {
            string exceptionMessage = MoodAnalyserReflector.CreateObject("Test").ToString();
            Assert.AreEqual("No Such Class Error", exceptionMessage);
        }

        [Test]
        public void GivenMoodAnalyserProperThroughConstructor_WhenAnalyse_ReturnMoodAnalyserObject()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer("Hello");
            Assert.IsTrue(moodAnalyzer.Equals(moodAnalyzer));
        }

        [Test]
        public void GivenClassNameImproperThroughConstructor_WhenAnalyse_ReturnMoodAnalysisException()
        {
            string exceptionMessage = MoodAnalyserReflector.CreateObject("Test","Hello").ToString();
            Assert.AreEqual("No Such Class Error", exceptionMessage);
        }

        [Test]
        public void GivenHappyMessageUsingReflection_WhenAnalyse_ReturnHappyMood()
        {
            MoodAnalyzer moodAnalyzer = (MoodAnalyzer)MoodAnalyserReflector.CreateObject("MoodAnalyzer", "Happy");
            string actual = moodAnalyzer.GetType().GetMethod("AnalyseMood").Invoke(moodAnalyzer, null).ToString();
            Assert.AreEqual("HAPPY", actual);
        }
    }
}