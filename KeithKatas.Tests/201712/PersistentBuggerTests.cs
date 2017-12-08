using Kata.December2017;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class PersistentBuggerTests
    {
        [Test]
        public void PersistentBugger_Persistence_Test1()
        {
            Console.WriteLine("****** Basic Tests");
            Assert.AreEqual(3, PersistentBugger.Persistence(39));
            Assert.AreEqual(0, PersistentBugger.Persistence(4));
            Assert.AreEqual(2, PersistentBugger.Persistence(25));
            Assert.AreEqual(4, PersistentBugger.Persistence(999));
        }
    }
}
