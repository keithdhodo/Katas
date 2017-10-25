using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;

namespace Sandbox
{
    [TestClass]
    public class NumberSeries3Tests
    {
        Sum s = new Sum();

        [TestMethod]
        public void NumberSeries3TestsGivenTest()
        {
            Assert.AreEqual(1, s.GetSum(0, 1));
            Assert.AreEqual(-1, s.GetSum(0, -1));
        }
    }
}
