using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;

namespace Sandbox
{
    [TestClass]
    public class BitCountTests
    {
        [TestMethod]
        public void CountBits()
        {
            Assert.AreEqual(0, BitCount.CountBits(0));
            Assert.AreEqual(1, BitCount.CountBits(4));
            Assert.AreEqual(3, BitCount.CountBits(7));
            Assert.AreEqual(2, BitCount.CountBits(9));
            Assert.AreEqual(2, BitCount.CountBits(10));
        }
    }
}
