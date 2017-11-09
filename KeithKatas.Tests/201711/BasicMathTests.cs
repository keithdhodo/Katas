using Kata.November2017;
using NUnit.Framework;
using System;

namespace KeithKatas.Tests.November2017
{
    [TestFixture]
    public class BasicPathTests
    {
        [Test]
        public void BasicPathTests_StaticTests()
        {
            Assert.AreEqual(BasicMath.BasicOperation('+', 4, 7), 11);
            Assert.AreEqual(BasicMath.BasicOperation('-', 15, 18), -3);
            Assert.AreEqual(BasicMath.BasicOperation('*', 5, 5), 25);
            Assert.AreEqual(BasicMath.BasicOperation('/', 49, 7), 7);
        }

        [Test]
        public void BasicPathTests_RandomTests()
        {
            char[] ops = { '+', '-', '*', '/' };
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {

                double val1 = rnd.Next(1, 999);
                double val2 = rnd.Next(1, 999);

                char op = ops[rnd.Next(1, 4)];

                Assert.AreEqual(BasicMath.BasicOperation(op, val1, val2), getResult(op, val1, val2));
            }
        }
        private static double getResult(char op, double val1, double val2)
        {
            if (op == '+') return val1 + val2;
            if (op == '-') return val1 - val2;
            if (op == '*') return val1 * val2;
            if (op == '/') return val1 / val2;
            return -1;
        }
    }
}
