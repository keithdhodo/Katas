using System;
using NUnit.Framework;
using Kata;

namespace Sandbox
{
    [TestFixture]
    public class VasyaClerkTests
    {
        [Test]
        public void VasyaClerkTestsTest1()
        {
            int[] peopleInLine = new int[] { 25, 25, 50, 50 };
            Assert.AreEqual("YES", VasyaClerk.Tickets(peopleInLine));
        }
        
        [Test]
        public void VasyaClerkTestsTest2()
        {
            int[] peopleInLine = new int[] { 25, 100 };
            Assert.AreEqual("NO", VasyaClerk.Tickets(peopleInLine));
        }

        [Test]
        public void VasyaClerkTestsTest3()
        {
            int[] peopleInLine = new int[] { 25, 25, 25, 25, 50, 100, 50 };
            Assert.AreEqual("YES", VasyaClerk.Tickets(peopleInLine));
        }
    }
}
