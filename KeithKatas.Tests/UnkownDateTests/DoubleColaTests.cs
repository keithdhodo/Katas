using System;
using NUnit.Framework;
using Kata;

namespace Sandbox
{
    [TestFixture]
    public class DoubleColaTests
    {
        [Test]
        public void DoubleColaTests1()
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            int n = 1;
            Assert.AreEqual("Sheldon", DoubleCola.WhoIsNext(names, n));
        }

        [Test]
        public void DoubleColaTests2()
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            int n = 6;
            Assert.AreEqual("Sheldon", DoubleCola.WhoIsNext(names, n));
        }

        [Test]
        public void DoubleColaTests3()
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            int n = 52;
            Assert.AreEqual("Penny", DoubleCola.WhoIsNext(names, n));
        }

        [Test]
        public void DoubleColaTests4()
        {
            string[] names = new string[] { "Sheldon", "Leonard", "Penny", "Rajesh", "Howard" };
            long n = 7230702951;
            Assert.AreEqual("Leonard", DoubleCola.WhoIsNext(names, n));
        }
    }
}
