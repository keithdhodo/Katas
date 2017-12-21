using KeithKatas.July2016;
using NUnit.Framework;

namespace Sandbox.July2016
{
    [TestFixture]
    public class LightSabersTests
    {
        [Test]
        public void LightSabersTests_Adam()
        {
            Assert.AreEqual(0, LightSabers.HowManyLightsabersDoYouOwn("Adam"));
        }

        [Test]
        public void LightSabersTests_Zach()
        {
            Assert.AreEqual(18, LightSabers.HowManyLightsabersDoYouOwn("Zach"));
        }
    }
}
