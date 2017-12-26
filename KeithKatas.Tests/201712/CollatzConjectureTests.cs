using KeithKatas.December2017;
using NUnit.Framework;
using System;
using System.Collections;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class CollatzConjectureTests
    {
        private static Random rnd = new Random();

        private static uint solution(uint n)
        {
            uint count = 0;

            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                }
                else
                {
                    n = n * 3 + 1;
                }
                ++count;
            }

            return count;
        }

        class HotpoSampleTestCases : IEnumerable
        {
            public IEnumerator GetEnumerator()
            {
                yield return new uint[] { 1u, 0u };
                yield return new uint[] { 5u, 5u };
                yield return new uint[] { 6u, 8u };
                yield return new uint[] { 23u, 15u };
            }
        }

        [TestCaseSource(typeof(HotpoSampleTestCases))]
        public void CollatzConjecture_Hotpo_SampleTest(uint input, uint expectedOutput)
        {
            Assert.AreEqual(0u, CollantzConjecture.Hotpo(1u));
            Assert.AreEqual(5u, CollantzConjecture.Hotpo(5u));
            Assert.AreEqual(8u, CollantzConjecture.Hotpo(6u));
            Assert.AreEqual(15u, CollantzConjecture.Hotpo(23u));

        }

        [Test, Description("Random Tests")]
        public void CollatzConjecture_Hotpo_RandomTests()
        {
            const int Tests = 1000;

            for (int i = 0; i < Tests; ++i)
            {
                uint n = (uint)rnd.Next(1, 10000000);

                uint expected = solution(n);
                uint actual = CollantzConjecture.Hotpo(n);
            }
        }
    }
}
