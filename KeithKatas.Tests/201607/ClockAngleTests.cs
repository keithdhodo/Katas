using KeithKatas.July2016;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sandbox._201607
{
    [TestClass]
    public class ClockAngleTests
    {
        [TestMethod]
        public void ClockAngleTest1()
        {
            Assert.AreEqual(18, ClockAngle.CalculateAngle(5, 24));
        }

        [TestMethod]
        public void ClockAngleTest2()
        {
            Assert.AreEqual(45, ClockAngle.CalculateAngle(7, 30));
        }
    }
}
