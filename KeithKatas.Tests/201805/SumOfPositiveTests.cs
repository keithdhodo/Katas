using KeithKatas.May2018;
using NUnit.Framework;
using System;
using System.Linq;

namespace KeithKatas.Tests.May2018
{
    [TestFixture]
    public class SumOfPositiveTests
    {
        [Test]
        public void SumOfPositive_Sum1Through5()
        {
            Assert.AreEqual(15, SumOfPositive.PositiveSum(new int[] { 1, 2, 3, 4, 5 }));
        }

        [Test]
        public void SumOfPositive_Sum1Negative2Through5()
        {
            Assert.AreEqual(13, SumOfPositive.PositiveSum(new int[] { 1, -2, 3, 4, 5 }));
        }

        [Test]
        public void SumOfPositive_SumNegative1ThenNegative5()
        {
            Assert.AreEqual(9, SumOfPositive.PositiveSum(new int[] { -1, 2, 3, 4, -5 }));
        }

        [Test]
        public void SumOfPositive_EmptyArray()
        {
            Assert.AreEqual(0, SumOfPositive.PositiveSum(new int[] {}));
        }

        [Test]
        public void SumOfPositive_NegativeOneThroughNegativeFive()
        {
            Assert.AreEqual(0, SumOfPositive.PositiveSum(new int[] { -1, -2, -3, -4, -5 }));
        }

        [Test]
        public static void RandomTest([Random(5, 120, 40)] int length)
        {
            int[] arr = RandomArray(length);
            Assert.AreEqual(Solution(arr), SumOfPositive.PositiveSum(arr), string.Format("Failed when arr = {0}", arr));
        }

        public static int[] RandomArray(int length)
        {
            int[] result = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < length; ++i)
            {
                result[i] = rnd.Next(-100, 100);
            }
            return result;
        }

        private static int Solution(int[] arr)
        {
            return arr.Where(x => x > 0).Sum();
        }
    }
}
