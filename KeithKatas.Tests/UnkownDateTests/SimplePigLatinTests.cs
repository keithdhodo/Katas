using System;
using NUnit.Framework;
using Kata;

namespace Sandbox
{
    [TestFixture]
    public class SimplePigLatinTests
    {
        [Test]
        public void SimplePigLatinTest1()
        {
            Assert.AreEqual("igPay atinlay siay oolcay", SimplePigLatin.PigIt("Pig latin is cool"));
            Assert.AreEqual("hisTay siay ymay tringsay", SimplePigLatin.PigIt("This is my string"));
        }
    }
}
