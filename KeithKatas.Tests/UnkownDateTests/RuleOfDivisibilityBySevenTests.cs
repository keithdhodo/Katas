using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestClass]
    public class RuleOfDivisibilityBySevenTests
    {
        [Ignore]
        [TestMethod]
        public void Test1()
        {
            Console.WriteLine("****** Basic Tests");
            Assert.AreEqual(new long[] { 7, 2 }, RuleOfDivisibilityBySeven.Seven(1603));
            Assert.AreEqual(new long[] { 35, 1 }, RuleOfDivisibilityBySeven.Seven(371));
            Assert.AreEqual(new long[] { 42, 1 }, RuleOfDivisibilityBySeven.Seven(483));
        }
    }
}
