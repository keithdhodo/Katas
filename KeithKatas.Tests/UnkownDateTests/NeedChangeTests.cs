using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestClass]
    public class NeedChangeTests
    {
        [TestMethod]
        public void NeedChangeTestsTest1()
        {
            var res = new Dictionary<string, int> { {"25", 1}, {"5", 1}, {"1", 1} };
            CollectionAssert.AreEquivalent(res, NeedChange.GetChange(31));
        }
    }
}
