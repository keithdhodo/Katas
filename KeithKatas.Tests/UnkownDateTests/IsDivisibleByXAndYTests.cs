using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestClass]
    public class IsDivisibleByXAndYTests
    {
        [TestMethod]
        public void IsDivisibleByXAndYTestsTest1()
        {
            Assert.AreEqual(true, IsDivisibleByXAndY.isDivisible(12, 4, 3));
        }
        [TestMethod]
        public void IsDivisibleByXAndYTestsTest2()
        {
            Assert.AreEqual(false, IsDivisibleByXAndY.isDivisible(3, 3, 4));
        }
        [TestMethod]
        public void IsDivisibleByXAndYTestsTest3()
        {
            Assert.AreEqual(false, IsDivisibleByXAndY.isDivisible(8, 3, 4));
        }
    }
}
