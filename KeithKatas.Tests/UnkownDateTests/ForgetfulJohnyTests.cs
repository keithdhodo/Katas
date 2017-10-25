using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestClass]
    public class ForgetfulJohnyTests
    {
        [TestMethod]
        public void ForgetfulJohnyTestsTestExampleOne()
        {
            Assert.AreEqual("VASUAussr", ForgetfulJohny.Pass("vasuaUSSR@yandex.ru"));
        }

        [TestMethod]
        public void ForgetfulJohnyTestsTestExampleTwo()
        {
            Assert.AreEqual("111hIrOdOt", ForgetfulJohny.Pass("HiRoDoT111@gmail.com"));
        }
    }
}
