using Kata;
using NUnit.Framework;

namespace Sandbox
{
    [TestFixture]
    public class WhichAreInUnitTests
    {
        [Test]
        public void WhichAreInTest1()
        {
            string[] a1 = new string[] { "arp", "live", "strong" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };
            string[] r = new string[] { "arp", "live", "strong" };

            CollectionAssert.AreEqual(r, WhichAreIn.InArray(a1, a2));
        }
    }
}
