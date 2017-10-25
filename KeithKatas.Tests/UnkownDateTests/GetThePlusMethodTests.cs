using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestClass]
    public class GetThePlusMethodTests
    {
        [TestMethod]
        public void GetThePlusMethodTestsTest1()
        {
            Assert.AreEqual(12, GetThePlusMethod.MethodFunc(2)(10));
        }

        [TestMethod]
        public void GetThePlusMethodTestsTest2()
        {
            Assert.AreEqual(20, GetThePlusMethod.MethodFunc(3)(17));
        }

        [TestMethod]
        public void GetThePlusMethodTestsTest3()
        {
            Assert.AreEqual(20351, GetThePlusMethod.MethodFunc(1456)(18895));
        }
    }
}
