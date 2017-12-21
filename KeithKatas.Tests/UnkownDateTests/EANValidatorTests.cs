using InterviewQuestions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestionsTests
{
    [TestFixture]
    public class EANValidatorTests
    {
        [Test]
        public void EANValidatorTestsTest1()
        {
            Assert.AreEqual(true, EANValidator.Validate("9783815820865"));
        }
        [Test]
        public void EANValidatorTestsTest2()
        {
            Assert.AreEqual(false, EANValidator.Validate("9783815820864"));
        }
        [Test]
        public void EANValidatorTestsTest3()
        {
            Assert.AreEqual(true, EANValidator.Validate("9783827317100"));
        }
    }
}
