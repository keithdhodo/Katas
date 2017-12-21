using System;
using NUnit.Framework;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestFixture]
    public class GetThePlusMethodTests
    {
        [Test]
        public void GetThePlusMethodTestsTest1()
        {
            Assert.AreEqual(12, GetThePlusMethod.MethodFunc(2)(10));
        }

        [Test]
        public void GetThePlusMethodTestsTest2()
        {
            Assert.AreEqual(20, GetThePlusMethod.MethodFunc(3)(17));
        }

        [Test]
        public void GetThePlusMethodTestsTest3()
        {
            Assert.AreEqual(20351, GetThePlusMethod.MethodFunc(1456)(18895));
        }
    }
}
