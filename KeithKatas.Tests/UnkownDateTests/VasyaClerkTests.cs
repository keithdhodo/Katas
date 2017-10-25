using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;

namespace Sandbox
{
    [TestClass]
    public class VasyaClerkTests
    {
        [TestMethod]
        public void VasyaClerkTestsTest1()
        {
            int[] peopleInLine = new int[] { 25, 25, 50, 50 };
            Assert.AreEqual("YES", VasyaClerk.Tickets(peopleInLine));
        }

        [Ignore]
        [TestMethod]
        public void VasyaClerkTestsTest2()
        {
            int[] peopleInLine = new int[] { 25, 100 };
            Assert.AreEqual("NO", VasyaClerk.Tickets(peopleInLine));
        }

        [TestMethod]
        public void VasyaClerkTestsTest3()
        {
            int[] peopleInLine = new int[] { 25, 25, 25, 25, 50, 100, 50 };
            Assert.AreEqual("YES", VasyaClerk.Tickets(peopleInLine));
        }
    }
}
