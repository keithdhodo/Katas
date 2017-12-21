using System;
using NUnit.Framework;
using Kata;

namespace Sandbox
{
    [TestFixture]
    public class VowelCountTests
    {
        [Test]
        public void VowelCountAbracadabraTest()
        {
            Assert.AreEqual(5, VowelCount.GetVowelCount("abracadabra"), "Nope!");
        }
    }
}
