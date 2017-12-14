using Kata.December2017;
using NUnit.Framework;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class DuplicateFinderTests
    {
        [Test]
        public void DuplicateFinder_DuplicateCount_KataTests()
        {
            Assert.AreEqual(0, DuplicateFinder.DuplicateCount(""));
            Assert.AreEqual(0, DuplicateFinder.DuplicateCount("abcde"));
            Assert.AreEqual(2, DuplicateFinder.DuplicateCount("aabbcde"));
            Assert.AreEqual(2, DuplicateFinder.DuplicateCount("aabBcde"), "should ignore case");
            Assert.AreEqual(1, DuplicateFinder.DuplicateCount("Indivisibility"));
            Assert.AreEqual(2, DuplicateFinder.DuplicateCount("Indivisibilities"), "characters may not be adjacent");
        }

        [Test]
        public void DuplicateFinder_DuplicateCount_RandomTests()
        {
            var random = new Random();
            string randomStr;
            for (int i = 0; i < 10; i++)
            {
                randomStr =
                  String.Join("", Enumerable.Range(0, 20).Select((o, x) => (char)random.Next('a', 'z') + (char)random.Next('A', 'Z')));

                Assert.AreEqual(Solution(randomStr), DuplicateFinder.DuplicateCount(randomStr));
            }
        }

        private static int Solution(string str)
        {
            str = String.Join("", str.ToLower().OrderBy(c => c));
            return Regex.Matches(str, @"(.)\1+").Count;
        }
    }
}
