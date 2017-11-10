using Kata.November2017;
using NUnit.Framework;
using System;

namespace KeithKatas.Tests.November2017
{
    [TestFixture]
    public class EvenOrOddTests
    {
        [Test]
        public void EvenOrOdd_GetEvenOrOdd_TwoReturnsEven()
        {
            // arrange

            // act

            // assert
            Assert.AreEqual("Even", EvenOrOdd.GetEvenOrOdd(2));
        }

        [Test]
        public void EvenOrOdd_GetEvenOrOdd_OneReturnsOdd()
        {
            // arrange

            // act

            // assert
            Assert.AreEqual("Odd", EvenOrOdd.GetEvenOrOdd(1));
        }

        [Test]
        public void EvenOrOdd_GetEvenOrOdd_Random()
        {
            const int Tests = 100;
            var random = new Random();

            for (int i = 0; i < Tests; ++i)
            {
                var randomNumber = random.Next();

                var expected = randomNumber % 2 == 0 ? "Even" : "Odd";

                // assert
                Assert.AreEqual(expected, EvenOrOdd.GetEvenOrOdd(randomNumber));
            }
        }
    }
}
