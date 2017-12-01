using Kata.December2017;
using NUnit.Framework;
using System;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class ReturnNegativeTests
    {
        [Test]
        public void ReturnNegative_MakeNegative_Test1()
        {
            Assert.AreEqual(-42, ReturnNegative.MakeNegative(42));
        }

        Random r = new Random();

        [Test]
        public void ReturnNegative_MakeNegative_PositiveTest()
        {
            Assert.AreEqual(-42, ReturnNegative.MakeNegative(42));
        }

        [Test]
        public void ReturnNegative_MakeNegative_NegativeTest()
        {
            Assert.AreEqual(-9, ReturnNegative.MakeNegative(-9));
        }

        [Test]
        public void ReturnNegative_MakeNegative_ZeroTest()
        {
            Assert.AreEqual(0, ReturnNegative.MakeNegative(0));
        }

        [Test]
        public void ReturnNegative_MakeNegative_RandomPositiveTest()
        {
            int number = r.Next(1, 101);
            Assert.AreEqual(-Math.Abs(number), ReturnNegative.MakeNegative(number));
        }

        [Test]
        public void ReturnNegative_MakeNegative_RandomNegativeTest()
        {
            int number = r.Next(-100, 0);
            Assert.AreEqual(-Math.Abs(number), ReturnNegative.MakeNegative(number));
        }
    }
}
