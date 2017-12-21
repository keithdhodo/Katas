using System;
using NUnit.Framework;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestFixture]
    public class DivisibleByFourUnitTests
    {
        [Test]
        public void DivisibleByFourTests()
        {
            Assert.AreEqual(true, DivisibleByFour.IsDivisibleByFour(4));
            Assert.AreEqual(false, DivisibleByFour.IsDivisibleByFour(5));
        }
    }
}
