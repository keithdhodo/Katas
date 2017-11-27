using Kata.November2017;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace KeithKatas.Tests.November2017
{
    [TestFixture]
    public class IsogramTests
    {
        private static IEnumerable<TestCaseData> Isogram_IsIsogram_TestCases
        {
            get
            {
                yield return new TestCaseData("Dermatoglyphics").Returns(true);
                yield return new TestCaseData("isogram").Returns(true);
                yield return new TestCaseData("moose").Returns(false);
                yield return new TestCaseData("isIsogram").Returns(false);
                yield return new TestCaseData("aba").Returns(false);
                yield return new TestCaseData("moOse").Returns(false);
                yield return new TestCaseData("thumbscrewjapingly").Returns(true);
                yield return new TestCaseData("").Returns(true);
            }
        }

        [Test, TestCaseSource("Isogram_IsIsogram_TestCases")]
        public bool Isogram_IsIsogram_Test(string str) => Isogram.IsIsogram(str);

        private static readonly string _lowers = "abcdefghijklmnopqrstuvwxyz";
        private static readonly string _uppers = _lowers.ToUpper();

        [Test]
        public void Isogram_IsIsogram_LowerCaseAlphabetPlusOneChar()
        {
            Random rnd = new Random();
            Assert.IsFalse(Isogram.IsIsogram(String.Format("{0}{1}", _lowers, _lowers[rnd.Next(0, _lowers.Length)])));
        }

        [Test]
        public void Isogram_IsIsogram_UpperCaseAlphabetPlusOneChar()
        {
            Random rnd = new Random();
            Assert.IsFalse(Isogram.IsIsogram(String.Format("{0}{1}", _uppers, _uppers[rnd.Next(0, _uppers.Length)])));
        }

        [Test]
        public void Isogram_IsIsogram_RandomTest()
        {
            var randomTestStr = "";
            Random rnd = new Random();
            var isIsogram = true;

            for (var i = 0; i < 100; i++)
            {
                var thisChar = rnd.Next(0, 99) < 50 ?
                                _lowers[(rnd.Next(0, _lowers.Length))]
                                : _uppers[(rnd.Next(0, _uppers.Length))];
                if (randomTestStr.ToUpper().Contains(thisChar.ToString().ToUpper())) isIsogram = false;
                randomTestStr += thisChar;
            }

            Console.WriteLine(String.Format("Test string for Random Tests: {0}", randomTestStr));
            Assert.AreEqual(isIsogram, Isogram.IsIsogram(randomTestStr));
        }
    }
}
