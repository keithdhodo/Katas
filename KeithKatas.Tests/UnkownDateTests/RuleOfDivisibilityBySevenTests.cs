using System;
using NUnit.Framework;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestFixture]
    public class RuleOfDivisibilityBySevenTests
    {
        [Test]
        public void RuleOfDivisibilityBySeven_SampleTests()
        {
            Console.WriteLine("****** Basic Tests");
            Assert.AreEqual(new long[] { 7, 2 }, RuleOfDivisibilityBySeven.Seven(1603));
            Assert.AreEqual(new long[] { 35, 1 }, RuleOfDivisibilityBySeven.Seven(371));
            Assert.AreEqual(new long[] { 42, 1 }, RuleOfDivisibilityBySeven.Seven(483));
        }
    }
}
