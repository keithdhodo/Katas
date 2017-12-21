using System;
using NUnit.Framework;
using Kata;

namespace Sandbox
{
    [TestFixture]
    public class BlockTests
    {
        [Test]
        public void BlockTests1()
        {
            Block b = new Block(new int[] { 2, 2, 2 });
            Assert.AreEqual(2, b.GetWidth());
            Assert.AreEqual(2, b.GetLength());
            Assert.AreEqual(2, b.GetHeight());
            Assert.AreEqual(8, b.GetVolume());
            Assert.AreEqual(24, b.GetSurfaceArea());
        }
    }
}
