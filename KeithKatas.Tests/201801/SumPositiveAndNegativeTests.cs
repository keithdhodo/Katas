using KeithKatas.January2018;
using NUnit.Framework;
using System;
using System.Linq;

namespace KeithKatas.Tests.January2018
{
    [TestFixture]
    public class SumPositiveAndNegativeTests
    {
        private static Random random = new Random();

        public int[] CountPositivesSumNegatives(int[] input)
        {
            if (input == null || !input.Any())
            {
                return new int[] { };
            }

            int countPositives = input.Count(n => n > 0);
            int sumNegatives = input.Where(n => n < 0).Sum();

            return new int[] { countPositives, sumNegatives };
        }

        [Test]
        public void SumPositiveAndNegative_CountPositivesSumNegatives_BasicTest()
        {
            int[] expectedResult = new int[] { 10, -65 };

            Assert.AreEqual(expectedResult, SumPositiveAndNegative.CountPositivesSumNegatives(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 }));
        }

        [Test]
        public void SumPositiveAndNegative_CountPositivesSumNegatives_InputWithZeroes()
        {
            int[] expectedResult = new int[] { 8, -50 };

            Assert.AreEqual(expectedResult, SumPositiveAndNegative.CountPositivesSumNegatives(new[] { 0, 2, 3, 0, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14 }));
        }

        [Test]
        public void SumPositiveAndNegative_CountPositivesSumNegatives_InputNull()
        {
            int[] expectedResult = new int[] { };

            Assert.AreEqual(expectedResult, SumPositiveAndNegative.CountPositivesSumNegatives(null));
        }

        [Test]
        public void SumPositiveAndNegative_CountPositivesSumNegatives_InputEmpty()
        {
            int[] expectedResult = new int[] { };

            Assert.AreEqual(expectedResult, SumPositiveAndNegative.CountPositivesSumNegatives(new int[] { }));
        }

        [Test]
        public void SumPositiveAndNegative_CountPositivesSumNegatives_RandomTests()
        {
            for (int i = 0; i < 20; i++)
            {
                int elementsNumber = random.Next(0, 100);
                int[] input = new int[elementsNumber];
                for (int j = 0; j < elementsNumber; j++)
                {
                    input[j] = random.Next(-500, 500);
                }

                Assert.AreEqual(CountPositivesSumNegatives(input), SumPositiveAndNegative.CountPositivesSumNegatives(input));
            }
        }
    }
}
