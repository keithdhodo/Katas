using Kata.November2017;
using NUnit.Framework;
using System;

namespace KeithKatas.Tests.November2017
{
    [TestFixture]
    public class RealFloorTests
    {
        [Test, Description("should return a correct value for floors lower than 13")]
        public void RealFloor_GetRealFloor_LessThan13Test()
        {
            Assert.AreEqual(0, RealFloor.GetRealFloor(0));
            Assert.AreEqual(0, RealFloor.GetRealFloor(1));
            Assert.AreEqual(4, RealFloor.GetRealFloor(5));
            Assert.AreEqual(9, RealFloor.GetRealFloor(10));
        }

        [Test, Description("should return a correct value for floors greater than 13")]
        public void RealFloor_GetRealFloor_GreaterThan13Test()
        {
            Assert.AreEqual(13, RealFloor.GetRealFloor(15));
            Assert.AreEqual(35, RealFloor.GetRealFloor(37));
            Assert.AreEqual(198, RealFloor.GetRealFloor(200));
        }

        [Test, Description("should return a correct value for basement floors")]
        public void RealFloor_GetRealFloor_BasementTest()
        {
            Assert.AreEqual(-2, RealFloor.GetRealFloor(-2));
            Assert.AreEqual(-5, RealFloor.GetRealFloor(-5));
        }

        [Test, Description("Random tests")]
        public void RealFloor_GetRealFloor_RandTest()
        {
            Random rnd = new Random();

            for (int i = 0; i < 100; ++i)
            {
                int n = rnd.Next(-100, 100);
                if (n == 13) { n += rnd.Next(10, 70); }

                Assert.AreEqual(GetRealFloor(n), RealFloor.GetRealFloor(n));
            }
        }

        public static int GetRealFloor(int n)
        {
            if (n <= 0) { return n; }
            if (n < 13) { return n - 1; }
            return n - 2;
        }
    }
}
