using KeithKatas.January2018;
using NUnit.Framework;
using System;
using System.Linq;

namespace KeithKatas.Tests.January2018
{
    [TestFixture]
    public class SortInnerContentTests
    {
        [Test]
        public void SortInnerContent_SortTheInnerContent_ExampleTests()
        {
            Assert.AreEqual("srot the inner ctonnet in dsnnieedcg oredr", SortInnerContent.SortTheInnerContent("sort the inner content in descending order"));
            Assert.AreEqual("wiat for me", SortInnerContent.SortTheInnerContent("wait for me"));
            Assert.AreEqual("tihs ktaa is esay", SortInnerContent.SortTheInnerContent("this kata is easy"));
        }

        [Test]
        public void SortInnerContent_SortTheInnerContent_RandomTests()
        {
            Func<string, string> mySortTheInnerContent = delegate (string words)
            {
                return string.Join(" ", words.Split(' ').Select(w =>
                {
                    if (w.Length < 3)
                    {
                        return w;
                    }
                    return w.First() + string.Concat(w.Substring(1, w.Length - 2).OrderByDescending(l => l)) + w.Last();
                }));
            };

            var rand = new Random();

            var alphabet = "abcdefghijklmnopqrstuvwxyz";
            for (var r = 0; r < 40; r++)
            {
                var wordCount = rand.Next(1, 10);
                var words = string.Join(" ", Enumerable.Range(0, wordCount).Select(w => string.Concat(Enumerable.Range(0, rand.Next(1, 10)).Select(l => alphabet[rand.Next(0, alphabet.Length - 1)]))));

                var expected = mySortTheInnerContent(words);

                Assert.AreEqual(expected, SortInnerContent.SortTheInnerContent(words));
            }
        }
    }
}
