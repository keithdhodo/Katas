using Kata.November2017;
using NUnit.Framework;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace KeithKatas.Tests.November2017
{
    [TestFixture]
    public class WeirdStringCasingTests
    {
        [Test]
        public static void WeirdStringCasing_ToWeirdCase_ShouldWorkForSomeExamples()
        {
            Assert.AreEqual("ThIs", WeirdStringCasing.ToWeirdCase("This"));
            Assert.AreEqual("Is", WeirdStringCasing.ToWeirdCase("is"));
            Assert.AreEqual("ThIs Is A TeSt", WeirdStringCasing.ToWeirdCase("This is a test"));
        }

        [Test]
        public static void WeirdStringCasing_ToWeirdCase_ShouldWorkForWhitespace()
        {
            Assert.AreEqual("", WeirdStringCasing.ToWeirdCase(""), "Empty strings should work too!");
            Assert.AreEqual("    ", WeirdStringCasing.ToWeirdCase("    "), "Whitespace should work too!");
        }
        [Test]
        public static void WeirdStringCasing_ToWeirdCase_ShouldWorkForSymbols()
        {
            Assert.AreEqual("!@#$%^&*()", WeirdStringCasing.ToWeirdCase("!@#$%^&*()"), "Odd characters have to work");
        }
        [Test]
        public static void WeirdStringCasing_ToWeirdCase_ShouldWorkForMoreComplexStrings()
        {
            Assert.AreEqual("OnCe, WhEn I WaS YoUnG, I CoDeD On ThE AmIgA!", WeirdStringCasing.ToWeirdCase("Once, when I was young, I coded on the Amiga!"));
        }

        private static Random rnd = new Random();
        private static string chars = "                 abcdefghijlmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private static string solution(string s) =>
          String.Join(" ", s.Split(' ').Select(word => String.Concat(word.Select((ch, idx) => idx % 2 == 0 ? Char.ToUpper(ch) : Char.ToLower(ch)))));

        [Test]
        public void WeirdStringCasing_ToWeirdCase_RandomTest()
        {
            const int Tests = 1000;

            for (int i = 0; i < Tests; ++i)
            {
                string s = new Regex(@"\s+").Replace(String.Concat(new char[rnd.Next(5, 100)].Select(_ => chars[rnd.Next(0, chars.Length)])), " ").Trim();
                if (s == String.Empty) { s = "a"; }

                string expected = solution(s);
                string actual = WeirdStringCasing.ToWeirdCase(s);

                Assert.AreEqual(expected, actual);
            }
        }
    }
}
