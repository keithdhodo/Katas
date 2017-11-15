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
    public class MathematicsTests
    {
        [Test]
        public void Mathematics_SumTwoSmallestNumbers_SampleTest()
        {
            int[] numbers = { 5, 8, 12, 19, 22 };
            Assert.AreEqual(13, Mathematics.SumTwoSmallestNumbers(numbers));
        }

        [Test]
        public void Mathematics_SumTwoSmallestNumbers_Test2()
        {
            int[] numbers = { 15, 28, 4, 2, 43 };
            Assert.AreEqual(6, Mathematics.SumTwoSmallestNumbers(numbers));
        }

        [Test]
        public void Mathematics_SumTwoSmallestNumbers_Test3()
        {
            int[] numbers = { 3, 87, 45, 12, 7 };
            Assert.AreEqual(10, Mathematics.SumTwoSmallestNumbers(numbers));
        }

        [Test]
        public void Mathematics_SumTwoSmallestNumbers_Test4()
        {
            int[] numbers = { 23, 71, 33, 82, 1 };
            Assert.AreEqual(24, Mathematics.SumTwoSmallestNumbers(numbers));
        }

        [Test]
        public void Mathematics_SumTwoSmallestNumbers_Test5()
        {
            int[] numbers = { 52, 76, 14, 12, 4 };
            Assert.AreEqual(16, Mathematics.SumTwoSmallestNumbers(numbers));
        }

        private static Random rnd = new Random();

        private static int solution(int[] numbers) => numbers.OrderBy(i => i).Take(2).Sum();

        [Test]
        public void Mathematics_SumTwoSmallestNumbers_RandomTests()
        {
            var numbers = new int[rnd.Next(0, 100)];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next();

                int expected = solution(numbers);
                int actual = Mathematics.SumTwoSmallestNumbers(numbers);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
