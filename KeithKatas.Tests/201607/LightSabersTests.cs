using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata.July2016;

namespace Sandbox.July2016
{
    [TestClass]
    public class LightSabersTests
    {
        [TestMethod]
        public void LightSabersTests_Adam()
        {
            Assert.AreEqual(0, LightSabers.HowManyLightsabersDoYouOwn("Adam"));
        }

        [TestMethod]
        public void LightSabersTests_Zach()
        {
            Assert.AreEqual(18, LightSabers.HowManyLightsabersDoYouOwn("Zach"));
        }
    }
}
