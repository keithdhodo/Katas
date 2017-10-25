using System;
using InterviewQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewQuestionsTests
{
    [TestClass]
    public class DigitalRootTests
    {
        private DigitalRoot num;

        [TestInitialize]
        public void SetUp()
        {
            num = new DigitalRoot();
        }

        [TestCleanup]
        public void TearDown()
        {
            num = null;
        }

        [TestMethod]
        public void DigitalRootTestsTest16Returns7()
        {
            Assert.AreEqual(7, num.SumOfDigits(16));
        }

        [TestMethod]
        public void DigitalRootTestsTest942Returns6()
        {
            Assert.AreEqual(6, num.SumOfDigits(942));
        }

        [TestMethod]
        public void DigitalRootTestsTest132189Returns6()
        {
            Assert.AreEqual(6, num.SumOfDigits(132189));
        }

        [TestMethod]
        public void DigitalRootTestsTest493193Returns6()
        {
            Assert.AreEqual(2, num.SumOfDigits(493193));
        }
    }
}
