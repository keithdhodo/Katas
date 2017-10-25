using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;

namespace Sandbox
{
    [TestClass]
    public class HighAndLowTests
    {
        [TestMethod]
        public void HighAndLowTest1()
        {
            Assert.AreEqual("42 -9", HighAndLow.HighAndLowNumbers("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }
    }
}
