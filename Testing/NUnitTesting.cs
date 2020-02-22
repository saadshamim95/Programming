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
            string actual = moodAnalyzer.AnalyseMood();
            Assert.AreEqual("SAD", actual);
        }
    }
}