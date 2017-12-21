using KeithKatas.August2016;
using NUnit.Framework;

namespace Sandbox
{
    [TestFixture]
    public class HexStringToDecimalTests
    {
        [Test]
        public void HexStringToDecimal1()
        {
            Assert.AreEqual(1, HexStringToDecimal.HexToDec("1"));
            Assert.AreEqual(10, HexStringToDecimal.HexToDec("a"));
            Assert.AreEqual(16, HexStringToDecimal.HexToDec("10"));
            Assert.AreEqual(255, HexStringToDecimal.HexToDec("FF"));
            Assert.AreEqual(-12, HexStringToDecimal.HexToDec("-C"));
        }
    }
}
