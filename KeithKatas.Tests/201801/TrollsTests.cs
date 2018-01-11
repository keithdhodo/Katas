using KeithKatas.January2018;
using NUnit.Framework;

namespace KeithKatas.Tests.January2018
{
    [TestFixture]
    public class TrollsTests
    {
        [Test]
        public void Trolls_Disemvowel_ShouldRemoveAllVowels()
        {
            Assert.AreEqual(Trolls.Disemvowel("This website is for losers LOL!"),
            "Ths wbst s fr lsrs LL!");
        }

        [Test]
        public void Trolls_Disemvowel_MultilineString()
        {
            Assert.AreEqual(Trolls.Disemvowel("No offense but,\nYour writing is among the worst I've ever read"),
            "N ffns bt,\nYr wrtng s mng th wrst 'v vr rd");
        }

        [Test]
        public void Trolls_Disemvowel_OneMoreForGoodMeasure()
        {
            Assert.AreEqual(Trolls.Disemvowel("What are you, a communist?"),
            "Wht r y,  cmmnst?");
        }
    }
}
