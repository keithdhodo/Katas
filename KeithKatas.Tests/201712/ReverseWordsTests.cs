using Kata.December2017;
using NUnit.Framework;
using System;
using System.Linq;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class ReverseWordsTests
    {
        [Test]
        public void ReverseWords_Reverse_BasicTests()
        {
            Assert.AreEqual("world! hello", ReverseWords.Reverse("hello world!"));
            Assert.AreEqual("this like speak doesn't yoda", ReverseWords.Reverse("yoda doesn't speak like this"));
            Assert.AreEqual("foobar", ReverseWords.Reverse("foobar"));
            Assert.AreEqual("kata editor", ReverseWords.Reverse("editor kata"));
            Assert.AreEqual("boat your row row row", ReverseWords.Reverse("row row row your boat"));
        }

        [Test]
        public void ReverseWords_Reverse_RandomTests()
        {
            var rand = new Random();

            for (int k = 0; k < 40; ++k)
            {
                var length = rand.Next(0, 30);
                var str = string.Concat(Enumerable.Range(0, length).Select(a => rand.Next(1, 11) % 4 == 0 ? ' ' : (char)rand.Next(65, 90)));

                Assert.AreEqual(string.Join(" ", str.Split(' ').Reverse()), ReverseWords.Reverse(str), str + " wasn't reversed correctly!");
            }
        }
    }
}
