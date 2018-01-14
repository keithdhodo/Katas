using KeithKatas.January2018;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KeithKatas.Tests.January2018
{
    [TestFixture]
    public class StringDuplicateTests
    {
        [Test]
        public void StringDuplicate_DuplicateEncode_BasicTests()
        {
            Assert.AreEqual("(((", StringDuplicate.DuplicateEncode("din"));
            Assert.AreEqual("()()()", StringDuplicate.DuplicateEncode("recede"));
            Assert.AreEqual(")())())", StringDuplicate.DuplicateEncode("Success"), "should ignore case");
            Assert.AreEqual("))((", StringDuplicate.DuplicateEncode("(( @"));
        }

        [Test]
        public void StringDuplicate_DuplicateEncode_ParenthesesTests()
        {
            Assert.AreEqual("))((", StringDuplicate.DuplicateEncode("(( @"));
            Assert.AreEqual(")))))(", StringDuplicate.DuplicateEncode(" ( ( )"));
        }

        [Test]
        public void StringDuplicate_DuplicateEncode_RandomTests()
        {
            var rand = new Random();

            Func<string, string> myDuplicateEncode = delegate (string word)
            {
                Dictionary<char, int> dict = new Dictionary<char, int>();
                for (int i = 0; i < word.Length; i++)
                {
                    if (!dict.ContainsKey(char.ToLower(word[i])))
                    {
                        dict.Add(char.ToLower(word[i]), 0);
                    }
                    dict[char.ToLower(word[i])]++;
                }
                string result = "";

                for (var i = 0; i < word.Length; i++)
                {
                    if (dict[char.ToLower(word[i])] == 1)
                    {
                        result += "(";
                    }
                    else
                    {
                        result += ")";
                    }
                }

                return result;
            };

            for (int r = 0; r < 10; r++)
            {
                var length = rand.Next(10, 21);
                var chars = "abcdeFGHIJklmnOPQRSTuvwxyz() @!";
                var word = string.Concat(Enumerable.Range(0, length).Select(a => chars[rand.Next(0, chars.Length)]));

                Assert.AreEqual(myDuplicateEncode(word), StringDuplicate.DuplicateEncode(word));
            }
        }
    }
}
