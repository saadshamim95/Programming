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
    }
}