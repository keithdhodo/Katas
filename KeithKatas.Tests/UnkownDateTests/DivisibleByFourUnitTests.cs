using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestClass]
    public class DivisibleByFourUnitTests
    {
        [TestMethod]
        public void DivisibleByFourTests()
        {
            Assert.AreEqual(true, DivisibleByFour.IsDivisibleByFour(4));
            Assert.AreEqual(false, DivisibleByFour.IsDivisibleByFour(5));
        }
    }
}
