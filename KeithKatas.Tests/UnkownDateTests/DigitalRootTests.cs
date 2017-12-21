using System;
using InterviewQuestions;
using NUnit.Framework;

namespace InterviewQuestionsTests
{
    [TestFixture]
    public class DigitalRootTests
    {
        private DigitalRoot num;

        [SetUp]
        public void SetUp()
        {
            num = new DigitalRoot();
        }

        [TearDown]
        public void TearDown()
        {
            num = null;
        }

        [Test]
        public void DigitalRootTestsTest16Returns7()
        {
            Assert.AreEqual(7, num.SumOfDigits(16));
        }

        [Test]
        public void DigitalRootTestsTest942Returns6()
        {
            Assert.AreEqual(6, num.SumOfDigits(942));
        }

        [Test]
        public void DigitalRootTestsTest132189Returns6()
        {
            Assert.AreEqual(6, num.SumOfDigits(132189));
        }

        [Test]
        public void DigitalRootTestsTest493193Returns6()
        {
            Assert.AreEqual(2, num.SumOfDigits(493193));
        }
    }
}
