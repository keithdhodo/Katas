using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestClass]
    public class VasyaAndDrinksTests
    {
        [TestMethod]
        public void VasyaAndDrinksTest1()
        {
            string fractions = "0 25 50 75";
            Assert.AreEqual(37.5000, VasyaAndDrinks.OrangeFraction(fractions));
        }

        [TestMethod]
        public void VasyaAndDrinksTest2()
        {
            string fractions = "50 50 100";
            Assert.AreEqual(66.6667, VasyaAndDrinks.OrangeFraction(fractions));
        }
    }
}
