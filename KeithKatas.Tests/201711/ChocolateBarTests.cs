using Kata.November2017;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeithKatas.Tests.November2017
{
    [TestFixture]
    public class ChocolateBarTests
    {
        [Test]
        public void ChocolateBar_BreakChocolate_SimpleTests()
        {
            Assert.AreEqual(24, ChocolateBar.BreakChocolate(5, 5));
            Assert.AreEqual(0, ChocolateBar.BreakChocolate(1, 1));
        }

        [Test]
        public void ChocolateBar_BreakChocolate_MoreSimpleTests()
        {
            Assert.AreEqual(24, ChocolateBar.BreakChocolate(5, 5));
            Assert.AreEqual(27, ChocolateBar.BreakChocolate(7, 4));
            Assert.AreEqual(0, ChocolateBar.BreakChocolate(1, 1));
            Assert.AreEqual(0, ChocolateBar.BreakChocolate(0, 0), "What If I Told You There is No Chocolate?");
            Assert.AreEqual(5, ChocolateBar.BreakChocolate(6, 1));
        }

        private static Random rnd = new Random();

        private static int solution(int n, int m) => (n <= 0 || m <= 0) ? 0 : n * (m - 1) + (n - 1);

        [Test]
        public void ChocolateBar_BreakChocolate_RandomTests()
        {
            for (int i = 0; i < 100; ++i)
            {
                int n = rnd.Next(0, 20);
                int m = rnd.Next(0, 20);

                int expected = solution(n, m);
                int actual = ChocolateBar.BreakChocolate(n, m);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
