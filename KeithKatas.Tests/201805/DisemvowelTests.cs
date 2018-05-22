using KeithKatas.May2018;
using NUnit.Framework;

namespace KeithKatas.Tests.May2018
{
    [TestFixture]
    public class DisemvowelTests
    {
        [Test]
        public void ShouldRemoveAllVowels()
        {
            Assert.AreEqual(Disemvowel.DisemvowelTrolls("This website is for losers LOL!"),
            "Ths wbst s fr lsrs LL!");
        }

        [Test]
        public void MultilineString()
        {
            Assert.AreEqual(Disemvowel.DisemvowelTrolls("No offense but,\nYour writing is among the worst I've ever read"),
            "N ffns bt,\nYr wrtng s mng th wrst 'v vr rd");
        }

        [Test]
        public void OneMoreForGoodMeasure()
        {
            Assert.AreEqual(Disemvowel.DisemvowelTrolls("What are you, a communist?"),
            "Wht r y,  cmmnst?");
        }
    }
}
