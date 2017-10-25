using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;

namespace Sandbox
{
    [TestClass]
    public class VowelCountTests
    {
        [TestMethod]
        public void VowelCountAbracadabraTest()
        {
            Assert.AreEqual(5, VowelCount.GetVowelCount("abracadabra"), "Nope!");
        }
    }
}
