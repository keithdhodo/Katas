using Kata.December2017;
using NUnit.Framework;
using System;
using System.Linq;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class ShortLongShortTests
    {
        [Test]
        public void ShortLongShort_Solution_BasicTest()
        {
            Assert.AreEqual("abba", ShortLongShort.Solution("a", "bb"));
            Assert.AreEqual("baab", ShortLongShort.Solution("aa", "b"));

            Assert.AreEqual("1221", ShortLongShort.Solution("1", "22"));
            Assert.AreEqual("1221", ShortLongShort.Solution("22", "1"));
            Assert.AreEqual("12321", ShortLongShort.Solution("232", "1"));
            Assert.AreEqual("232", ShortLongShort.Solution("232", ""));
            Assert.AreEqual("2322132232", ShortLongShort.Solution("232", "2132"));
        }

        [Test]
        public void ShortLongShort_Solution_RandomTest()
        {
            var rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                var length1 = rand.Next(0, 10);
                int length2 = -1;
                do
                {
                    length2 = rand.Next(0, 10);
                }
                while (length1 == length2);

                var string1 = string.Concat(Enumerable.Range(0, length1).Select(o => new string((char)rand.Next(48, 90), 1)));
                var string2 = string.Concat(Enumerable.Range(0, length2).Select(o => new string((char)rand.Next(48, 90), 1)));

                var shortString = string1.Length < string2.Length ? string1 : string2;
                var longString = string1.Length > string2.Length ? string1 : string2;

                var expected = shortString + longString + shortString;

                Assert.AreEqual(expected, ShortLongShort.Solution(string1, string2));
            }
        }
    }
}
