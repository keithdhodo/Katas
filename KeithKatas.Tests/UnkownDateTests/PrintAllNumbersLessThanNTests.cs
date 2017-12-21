using System;
using NUnit.Framework;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestFixture]
    public class PrintAllNumbersLessThanNTests
    {
        PrintAllNumbersLessThanN k = new PrintAllNumbersLessThanN();
        
        [Test]
        public void SimpleNumbers()
        {
            Assert.AreEqual("1", k.Pattern(1));
            Assert.AreEqual("21\n2", k.Pattern(2));
            Assert.AreEqual("54321\n5432\n543\n54\n5", k.Pattern(5));
        }
    }
}
