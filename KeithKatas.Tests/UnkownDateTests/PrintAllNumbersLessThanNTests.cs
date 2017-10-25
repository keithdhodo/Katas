using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestClass]
    public class PrintAllNumbersLessThanNTests
    {
        PrintAllNumbersLessThanN k = new PrintAllNumbersLessThanN();

        [Ignore]
        [TestMethod]
        public void SimpleNumbers()
        {
            Assert.AreEqual("1", k.Pattern(1));
            Assert.AreEqual("21\n2", k.Pattern(2));
            Assert.AreEqual("54321\n5432\n543\n54\n5", k.Pattern(5));
        }
    }
}
