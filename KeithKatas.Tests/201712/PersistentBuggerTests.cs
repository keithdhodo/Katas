using Kata.December2017;
using NUnit.Framework;
using System;
using System.Linq;

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

        private static int Sol(long n)
        {
            int count = 0;
            while (n > 9)
            {
                count++;
                n = n.ToString().Select(digit => int.Parse(digit.ToString())).Aggregate((x, y) => x * y);
            }
            return count;
        }

        [Test]
        public static void PersistentBugger_Persistence_Random()
        {
            Console.WriteLine("\n 100 Random Tests ****************");
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                int n = rnd.Next(10, 500000);
                //Console.WriteLine("Numbers: n " + n);
                Assert.AreEqual(Sol(n), PersistentBugger.Persistence(n));
            }
        }
    }
}
