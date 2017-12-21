using System;
using NUnit.Framework;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestFixture]
    public class TankTruckTests
    {
        [Test]
        public void TankTruckTestsTest1()
        {
            Assert.AreEqual(1021, TankTruck.TankVol(40, 120, 3500));
            Assert.AreEqual(2940, TankTruck.TankVol(5, 7, 3848));
            Assert.AreEqual(907, TankTruck.TankVol(2, 7, 3848));
        }
    }
}
