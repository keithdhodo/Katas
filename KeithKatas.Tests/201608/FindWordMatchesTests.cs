using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Kata.August2016;

namespace Sandbox._201608
{
    [TestClass]
    public class FindWordMatchesTests
    {
        [TestMethod]
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
