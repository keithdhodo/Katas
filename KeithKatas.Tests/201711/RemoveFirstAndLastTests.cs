using Kata.November2017;
using NUnit.Framework;
using System;

namespace KeithKatas.Tests.November2017
{
    [TestFixture]
    public class RemoveFirstAndLastTests
    {
        [Test]
        public void RemoveFirstAndLast_RemoveCharacters_Test1()
        {
            StringAssert.AreEqualIgnoringCase("loquen", RemoveFirstAndLast.RemoveCharacters("eloquent"));
            StringAssert.AreEqualIgnoringCase("ountr", RemoveFirstAndLast.RemoveCharacters("country"));
            StringAssert.AreEqualIgnoringCase("erso", RemoveFirstAndLast.RemoveCharacters("person"));
            StringAssert.AreEqualIgnoringCase("lac", RemoveFirstAndLast.RemoveCharacters("place"));
            StringAssert.AreEqualIgnoringCase("", RemoveFirstAndLast.RemoveCharacters("ok"));
        }

        [Test]
        public void RemoveFirstAndLast_RemoveCharacters_RandomTest([Values(1)] int a, [Random(-1, 1, 30)] double d)
        {
            var rg = new Random((int)d * 10000);
            string s = rg.ToString();
            StringAssert.AreEqualIgnoringCase(Solution(s), RemoveFirstAndLast.RemoveCharacters(s));
        }

        private string Solution(string input)
        {
            return input.Length > 0 ? input.Substring(1, input.Length - 2) : string.Empty;
        }
    }
}
