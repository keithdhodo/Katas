using KeithKatas.July2016;
using NUnit.Framework;

namespace Sandbox._201607
{
    [TestFixture]
    public class ClockAngleTests
    {
        [Test]
        public void ClockAngleTest1()
        {
            Assert.AreEqual(18, ClockAngle.CalculateAngle(5, 24));
        }

        [Test]
        public void ClockAngleTest2()
        {
            Assert.AreEqual(45, ClockAngle.CalculateAngle(7, 30));
        }
    }
}
