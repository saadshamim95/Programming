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
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            string actual = moodAnalyzer.AnalyseMood("I am in Sad Mood");
            Assert.AreEqual("SAD", actual);
        }

        [Test]
        public void GivenAnyMessage_WhenAnalyse_ReturnHappy()
        {
            MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
            string actual = moodAnalyzer.AnalyseMood("I am in Any Mood");
            Assert.AreEqual("HAPPY", actual);
        }
    }
}