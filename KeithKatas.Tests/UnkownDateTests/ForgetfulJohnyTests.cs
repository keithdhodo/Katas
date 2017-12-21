using System;
using NUnit.Framework;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestFixture]
    public class ForgetfulJohnyTests
    {
        [Test]
        public void ForgetfulJohnyTestsTestExampleOne()
        {
            Assert.AreEqual("VASUAussr", ForgetfulJohny.Pass("vasuaUSSR@yandex.ru"));
        }

        [Test]
        public void ForgetfulJohnyTestsTestExampleTwo()
        {
            Assert.AreEqual("111hIrOdOt", ForgetfulJohny.Pass("HiRoDoT111@gmail.com"));
        }
    }
}
