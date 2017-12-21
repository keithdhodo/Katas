using System;
using NUnit.Framework;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestFixture]
    public class IsDivisibleByXAndYTests
    {
        [Test]
        public void IsDivisibleByXAndYTestsTest1()
        {
            Assert.AreEqual(true, IsDivisibleByXAndY.isDivisible(12, 4, 3));
        }
        [Test]
        public void IsDivisibleByXAndYTestsTest2()
        {
            Assert.AreEqual(false, IsDivisibleByXAndY.isDivisible(3, 3, 4));
        }
        [Test]
        public void IsDivisibleByXAndYTestsTest3()
        {
            Assert.AreEqual(false, IsDivisibleByXAndY.isDivisible(8, 3, 4));
        }
    }
}
