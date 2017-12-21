using System;
using NUnit.Framework;
using Kata;

namespace Sandbox
{
    [TestFixture]
    public class HighAndLowTests
    {
        [Test]
        public void HighAndLowTest1()
        {
            Assert.AreEqual("42 -9", HighAndLow.HighAndLowNumbers("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }
    }
}
