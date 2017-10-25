using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Kata.June2017;
using System.Linq;

namespace KataTests.June2017
{
    [TestFixture]
    public class PartialWordSearchingTests
    {
        [Test]
        public void PartialWordSearchingTestsBasicTests()
        {
            NUnit.Framework.Assert.AreEqual(new string[] { "ab", "abc", "zab" }, PartialWordSearching.WordSearch("ab", new string[] { "za", "ab", "abc", "zab", "zbc" }));
            NUnit.Framework.Assert.AreEqual(new string[] { "ab", "abc", "zab" }, PartialWordSearching.WordSearch("aB", new string[] { "za", "ab", "abc", "zab", "zbc" }));
            NUnit.Framework.Assert.AreEqual(new string[] { "aB", "Abc", "zAB" }, PartialWordSearching.WordSearch("ab", new string[] { "za", "aB", "Abc", "zAB", "zbc" }));
            NUnit.Framework.Assert.AreEqual(new string[] { "Empty" }, PartialWordSearching.WordSearch("abcd", new string[] { "za", "aB", "Abc", "zAB", "zbc" }));
        }

        [Test]
        public void RandomTests()
        {
            var letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var rand = new Random();

            Func<string, string[], string[]> wordSol = delegate (string query, string[] seq)
            {
                var res = seq.Where(a => a.ToLower().Contains(query.ToLower())).ToArray();
                return res.Length > 0 ? res : new string[] { "Empty" };
            };

            for (var r = 0; r < 40; r++)
            {
                var query = "";
                var queryLength = rand.Next(1, 5);

                var seqLength = rand.Next(0, 12);
                var seq = new string[seqLength];

                for (var i = 0; i < queryLength; i++)
                {
                    query += letters[rand.Next(0, letters.Length - 1)];
                }
                for (var i = 0; i < seqLength; i++)
                {
                    var templen = rand.Next(1, 15);
                    var temp = "";
                    for (var j = 0; j < templen; j++)
                    {
                        temp += letters[rand.Next(0, letters.Length - 1)];
                        if (rand.Next(0, 100) >= 95)
                        {
                            temp += query;
                        }
                    }
                    seq[i] = temp;
                }

                Console.WriteLine("Testing for wordSearch(" + query + ", {" + string.Join(", ", seq) + "})");
                NUnit.Framework.Assert.AreEqual(wordSol(query, seq), PartialWordSearching.WordSearch(query, seq), "It should work for random inputs too");
            }
        }
    }
}
