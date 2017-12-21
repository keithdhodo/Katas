using System;
using NUnit.Framework;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestFixture]
    public class VasyaAndDrinksTests
    {
        [Test]
        public void VasyaAndDrinksTest1()
        {
            string fractions = "0 25 50 75";
            Assert.AreEqual(37.5000, VasyaAndDrinks.OrangeFraction(fractions));
        }

        [Test]
        public void VasyaAndDrinksTest2()
        {
            string fractions = "50 50 100";
            Assert.AreEqual(66.6667, VasyaAndDrinks.OrangeFraction(fractions));
        }
    }
}
