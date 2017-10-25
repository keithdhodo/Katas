using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestClass]
    public class PetersAgeTests
    {
        [TestMethod]
        public void FirstTest()
        {
            DateTime birthday = new DateTime(2015, 10, 16);
            Assert.AreEqual(PetersAge.HowOld(birthday), PetersAge.HowOld(birthday));
        }
        [TestMethod]
        public void SecondTest()
        {
            DateTime birthday = new DateTime(2014, 12, 23);
            Assert.AreEqual(PetersAge.HowOld(birthday), PetersAge.HowOld(birthday));
        }
        [TestMethod]
        public void ThirdTest()
        {
            DateTime birthday = new DateTime(1983, 09, 21);
            Assert.AreEqual(PetersAge.HowOld(birthday), PetersAge.HowOld(birthday));
        }
        [TestMethod]
        public void FourthTest()
        {
            DateTime birthday = new DateTime(2015, 01, 30);
            Assert.AreEqual(PetersAge.HowOld(birthday), PetersAge.HowOld(birthday));
        }
    }
}
