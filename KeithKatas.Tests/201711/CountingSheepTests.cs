using Kata.November2017;
using NUnit.Framework;
using System;
using System.Linq;

namespace KeithKatas.Tests.November2017
{
    [TestFixture]
    public class CountingSheepTests
    {
        [Test]
        public void CountingSheep_CountSheep_SampleTest()
        {
            var sheeps = new bool[] { true, false, true };

            Assert.AreEqual(2, CountingSheep.CountSheep(sheeps));
        }

        [Test]
        public void CountingSheep_CountSheep_NumberOfTruesInArrayReturned()
        {
            var sheeps = new bool[] { true, false, true };

            Assert.AreEqual(2, CountingSheep.CountSheep(sheeps));

            sheeps = new bool[] { true, false, true, true, false, true, true, false, true };

            Assert.AreEqual(6, CountingSheep.CountSheep(sheeps));

            sheeps = new bool[] { true, true, true, true, true, true, true, true, true };

            Assert.AreEqual(9, CountingSheep.CountSheep(sheeps));

            sheeps = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false };

            Assert.AreEqual(0, CountingSheep.CountSheep(sheeps));
        }

        private static Random rnd = new Random();

        private static int solution(bool[] numbers) => numbers.Where(x => x.Equals(true)).Count();

        [Test]
        public void CountingSheep_CountSheep_RandomTests()
        {
            var numbers = new bool[rnd.Next(0, 100)];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(2) == 2;

                int expected = solution(numbers);
                int actual = CountingSheep.CountSheep(numbers);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
