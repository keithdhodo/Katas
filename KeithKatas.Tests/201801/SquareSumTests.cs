using KeithKatas.January2018;
using NUnit.Framework;
using System;
using System.Linq;

namespace KeithKatas.Tests.January2018
{
    [TestFixture]
    public class SquareSumTests
    {
        [Test, Description("Sample Test 1")]
        public void SquareSum_SquareAndSum_SampleTest1()
        {
            Assert.AreEqual(9, SquareSum.SquareAndSum(new int[] { 1, 2, 2 }));
        }

        [Test, Description("Sample Test 2")]
        public void SquareSum_SquareAndSum_SampleTest2()
        {
            Assert.AreEqual(5, SquareSum.SquareAndSum(new int[] { 1, 2 }));
        }

        [Test, Description("Sample Test 3")]
        public void SquareSum_SquareAndSum_SampleTest3()
        {
            Assert.AreEqual(50, SquareSum.SquareAndSum(new int[] { 5, 3, 4 }));
        }

        private static Random rnd = new Random();

        private static int Solution(int[] n) => n.Sum((v) => v * v);

        [Test, Description("Random Tests")]
        public void SquareSum_SquareAndSum_RandomTest()
        {
            for (int i = 0; i < 100; ++i)
            {
                int[] test = new int[rnd.Next(1, 10)].Select(_ => rnd.Next(0, 1000)).ToArray();
                int expected = Solution(test);
                int actual = SquareSum.SquareAndSum(test);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
