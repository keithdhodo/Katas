using KeithKatas.July2016;
using NUnit.Framework;

namespace Sandbox
{
    [TestFixture]
    public class ChineseZodiacTests
    {
        [Test]
        public void ChineseZodiacTest1()
        {
            Assert.AreEqual("Wood Snake", ChineseZodiac.GetChineseZodiac(1965));
            Assert.AreEqual("Earth Tiger", ChineseZodiac.GetChineseZodiac(1938));
            Assert.AreEqual("Earth Tiger", ChineseZodiac.GetChineseZodiac(1998));
            Assert.AreEqual("Fire Monkey", ChineseZodiac.GetChineseZodiac(2016));
            Assert.AreEqual("Wood Rat", ChineseZodiac.GetChineseZodiac(1924));
            Assert.AreEqual("Earth Monkey", ChineseZodiac.GetChineseZodiac(1968));
            Assert.AreEqual("Water Dog", ChineseZodiac.GetChineseZodiac(2162));
        }
    }
}
