using Kata.December2017;
using NUnit.Framework;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class CamelCaseTests
    {
        public string Solution(string str)
        {
            return Regex.Replace(str, @"[_-](\w)", m => m.Groups[1].Value.ToUpper());
        }

        [Test]
        public void CamelCase_ToCamelCase_KataTests()
        {
            Assert.AreEqual("theStealthWarrior", CamelCase.ToCamelCase("the_stealth_warrior"), "CamelCase.ToCamelCase('the_stealth_warrior') did not return correct value");
            Assert.AreEqual("TheStealthWarrior", CamelCase.ToCamelCase("The-Stealth-Warrior"), "CamelCase.ToCamelCase('The-Stealth-Warrior') did not return correct value");
        }

        [Test]
        public void CamelCase_ToCamelCase_SimpleTests()
        {
            Assert.AreEqual("", CamelCase.ToCamelCase(""), "An empty string was provided but not returned");
            Assert.AreEqual("ABC", CamelCase.ToCamelCase("A-B-C"), "CamelCase.ToCamelCase('A-B-C') did not return correct value");
        }

        [Test]
        public void CamelCase_ToCamelCase_RandomTests()
        {
            var random = new Random();
            string randomStr;
            for (int i = 0; i < 10; i++)
            {
                randomStr =
                  String.Join("", Enumerable.Range(0, 10).Select(o => (char)random.Next('a', 'z')))
                  + "_"
                  + String.Join("", Enumerable.Range(0, 10).Select(o => (char)random.Next('a', 'z')))
                  + "-"
                  + String.Join("", Enumerable.Range(0, 10).Select(o => (char)random.Next('a', 'z')));

                Assert.AreEqual(Solution(randomStr), CamelCase.ToCamelCase(randomStr));
            }
        }
    }
}
