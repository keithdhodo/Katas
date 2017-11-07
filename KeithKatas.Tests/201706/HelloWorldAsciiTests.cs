using KeithKatas.June2017;
using NUnit.Framework;

namespace KeithKatas.Tests.June2017
{
    [TestFixture]
    public class HelloWorldAsciiTests
    {
        [Test]
        public void CheckForHelloWorld()
        {
            NUnit.Framework.Assert.AreEqual("Hello, world!", HelloWorldAscii.F());
        }

        [Test]
        public void RandomTests()
        {
            for (int i = 0; i < 99; i++)
                NUnit.Framework.Assert.AreEqual("Hello, world!", HelloWorldAscii.F());
        }
    }
}
