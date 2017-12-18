using System;
using System.Collections.Generic;
using System.Linq;
using Kata.December2017;
using NUnit.Framework;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class RaulTests
    {
        [Test]
        public void Raul_SeparateKeywords_BasicTests()
        {
            var output = Raul.SeparateKeywords(new[] { "if", "finally", "goal" });
            Assert.AreEqual(2, output.Length, "Array must contain two lists!");
            Assert.AreEqual(2, output[0].Count, "Unexpected length for C#-keywords");
            Assert.AreEqual(1, output[1].Count, "Unexpected length for football-keywords");
            Assert.AreEqual(string.Join(", ", new[] { "finally", "if" }), string.Join(", ", output[0]));
            Assert.AreEqual(string.Join(", ", new[] { "goal" }), string.Join(", ", output[1]));

            output = Raul.SeparateKeywords(new[] { "class" });
            Assert.AreEqual(2, output.Length, "Array must contain two lists!");
            Assert.AreEqual(1, output[0].Count, "Unexpected length for C#-keywords");
            Assert.AreEqual(0, output[1].Count, "Unexpected length for football-keywords");
            Assert.AreEqual(string.Join(", ", new[] { "class" }), string.Join(", ", output[0]));

            output = Raul.SeparateKeywords(new[] { "namespace", "strawberry", "function", "team", "null", "privat", "public", "trainer" });
            Assert.AreEqual(2, output.Length, "Array must contain two lists!");
            Assert.AreEqual(3, output[0].Count, "Unexpected length for C#-keywords");
            Assert.AreEqual(2, output[1].Count, "Unexpected length for football-keywords");
            Assert.AreEqual(string.Join(", ", new[] { "namespace", "null", "public" }), string.Join(", ", output[0]));
            Assert.AreEqual(string.Join(", ", new[] { "team", "trainer" }), string.Join(", ", output[1]));
        }

        [Test]
        public void Raul_SeparateKeywords_RandomTests()
        {
            var rand = new Random();

            Func<string[], List<string>[]> mySeparateKeywords = delegate (string[] keywords)
            {
                var cSharpKeywords = new List<string>();
                var footballKeywords = new List<string>();

                foreach (string keyword in keywords)
                {
                    if (Raul.KeywordDictionary.ContainsKey(keyword))
                    {
                        if (Raul.KeywordDictionary[keyword] == "C#")
                        {
                            cSharpKeywords.Add(keyword);
                        }
                        if (Raul.KeywordDictionary[keyword] == "football")
                        {
                            footballKeywords.Add(keyword);
                        }
                    }
                }
                cSharpKeywords.Sort();
                footballKeywords.Sort();
                return new List<string>[] { cSharpKeywords, footballKeywords };
            };

            int[] indexes = Enumerable.Range(0, Raul.KeywordDictionary.Count).ToArray();

            for (int r = 0; r < 50; r++)
            {
                indexes = indexes.OrderBy(idx => rand.Next(-1, 2)).OrderBy(idx => rand.Next(-1, 2)).ToArray();

                var keywords = indexes.Take(rand.Next(2, 20)).Select(idx => Raul.KeywordDictionary.Keys.ToArray()[idx]).ToArray();

                var expectedArray = mySeparateKeywords(keywords.ToArray());
                var actualArray = Raul.SeparateKeywords(keywords.ToArray());
                Assert.AreEqual(2, actualArray.Length, "Array must contain two lists!");
                Assert.AreEqual(expectedArray[0].Count, actualArray[0].Count, "Unexpected length for C#-keywords");
                Assert.AreEqual(expectedArray[1].Count, actualArray[1].Count, "Unexpected length for football-keywords");
                Assert.AreEqual(string.Join(", ", expectedArray[0]), string.Join(", ", actualArray[0]));
                Assert.AreEqual(string.Join(", ", expectedArray[1]), string.Join(", ", actualArray[1]));
            }
        }
    }
}
