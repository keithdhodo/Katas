using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestClass]
    public class KeepUpTheHoopTests
    {
        [TestMethod]
        public void KeepUpTheHoopTestsFixedTest()
        {
            Assert.AreEqual("Keep at it until you get it", KeepUpTheHoop.HoopCount(6), "Should work for 6");
            Assert.AreEqual("Great, now move on to tricks", KeepUpTheHoop.HoopCount(22), "Should work for 22");
        }
    }
}
