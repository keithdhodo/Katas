using System;
using NUnit.Framework;
using System.Collections.Generic;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestFixture]
    public class FixerTests
    {
        [Test]
        public void FixThosePipes_t1()
        {
            CollectionAssert.AreEqual(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, Fixer.PipeFix(new List<int> { 1, 2, 3, 5, 6, 8, 9 }));
        }

        [Test]
        public void FixThosePipes_t2()
        {
            CollectionAssert.AreEqual(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 }, Fixer.PipeFix(new List<int> { 1, 2, 3, 12 }));
        }

        [Test]
        public void FixThosePipes_t3()
        {
            CollectionAssert.AreEqual(new List<int> { 6, 7, 8, 9 }, Fixer.PipeFix(new List<int> { 6, 9 }));
        }
    }
}
