using KeithKatas.August2016;
using NUnit.Framework;
using System.Collections.Generic;

namespace Sandbox._201608
{
    [TestFixture]
    public class FindWordMatchesTests
    {
        [Test]
        public void FindWordMatchesTest1()
        {
            List<string> data = new List<string>();
            data.Add("abc");
            data.Add("bcd");
            data.Add("cde");
            Assert.AreEqual(FindWordMatches.FindMatchCount(data, "bc"), 2);
        }
    }
}
