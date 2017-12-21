using System;
using NUnit.Framework;
using System.Collections.Generic;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestFixture]
    public class NeedChangeTests
    {
        [Test]
        public void NeedChangeTestsTest1()
        {
            var res = new Dictionary<string, int> { {"25", 1}, {"5", 1}, {"1", 1} };
            CollectionAssert.AreEquivalent(res, NeedChange.GetChange(31));
        }
    }
}
