using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestClass]
    public class StringCalculatorTests
    {
        [TestMethod]
        public void LessThan10()
        {
            Assert.AreEqual(5, StringCalculator.AddStrings("2, 3"));
        }

        [TestMethod]
        public void Over50()
        {
            Assert.AreEqual(60, StringCalculator.AddStrings("20, 20, 20"));
        }
    }
}
