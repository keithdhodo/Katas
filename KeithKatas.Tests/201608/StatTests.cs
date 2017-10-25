using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata.August2016;

namespace Sandbox
{
    [TestClass]
    public class StatTests
    {
        [Ignore]
        [TestMethod]
        public void StatTests_BasicTest()
        {
            string result = Stat.GetStats("01|15|59, 1|47|16, 01|17|20, 1|32|34, 2|17|17");

            Assert.AreEqual("Range: 01|01|18 Average: 01|38|05 Median: 01|32|34", result);

            string result2 = Stat.GetStats("02|15|59, 2|47|16, 02|17|20, 2|32|34, 2|17|17, 2|22|00, 2|31|41");

            Assert.AreEqual("Range: 00|31|17 Average: 02|26|18 Median: 02|22|00", result2);
        }
    }
}
