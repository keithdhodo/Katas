using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;

namespace Sandbox
{
    [TestClass]
    public class SimplePigLatinTests
    {
        [TestMethod]
        public void SimplePigLatinTest1()
        {
            Assert.AreEqual("igPay atinlay siay oolcay", SimplePigLatin.PigIt("Pig latin is cool"));
            Assert.AreEqual("hisTay siay ymay tringsay", SimplePigLatin.PigIt("This is my string"));
        }
    }
}
