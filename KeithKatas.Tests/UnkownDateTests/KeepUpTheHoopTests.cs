using System;
using NUnit.Framework;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestFixture]
    public class KeepUpTheHoopTests
    {
        [Test]
        public void KeepUpTheHoopTestsFixedTest()
        {
            Assert.AreEqual("Keep at it until you get it", KeepUpTheHoop.HoopCount(6), "Should work for 6");
            Assert.AreEqual("Great, now move on to tricks", KeepUpTheHoop.HoopCount(22), "Should work for 22");
        }
    }
}
