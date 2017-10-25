using InterviewQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestionsTests
{
    [TestClass]
    public class EANValidatorTests
    {
        [TestMethod]
        public void EANValidatorTestsTest1()
        {
            Assert.AreEqual(true, EANValidator.Validate("9783815820865"));
        }
        [TestMethod]
        public void EANValidatorTestsTest2()
        {
            Assert.AreEqual(false, EANValidator.Validate("9783815820864"));
        }
        [TestMethod]
        public void EANValidatorTestsTest3()
        {
            Assert.AreEqual(true, EANValidator.Validate("9783827317100"));
        }
    }
}
