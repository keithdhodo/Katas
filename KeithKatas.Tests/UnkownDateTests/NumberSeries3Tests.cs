using System;
using NUnit.Framework;
using Kata;

namespace Sandbox
{
    [TestFixture]
    public class NumberSeries3Tests
    {
        Sum s = new Sum();

        [Test]
        public void NumberSeries3TestsGivenTest()
        {
            Assert.AreEqual(1, s.GetSum(0, 1));
            Assert.AreEqual(-1, s.GetSum(0, -1));
        }
    }
}
