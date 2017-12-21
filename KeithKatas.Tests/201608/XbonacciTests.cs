using KeithKatas.August2016;
using NUnit.Framework;

namespace Sandbox._201608
{
    [TestFixture]
    public class XbonacciTests
    {
        [Test]
        public void XbonacciTest1()
        {
            CollectionAssert.AreEqual(new double[] { 1, 1, 1, 3, 5, 9, 17, 31, 57, 105 }, Xbonacci.Tribonacci(new double[] { 1, 1, 1 }, 10));
            CollectionAssert.AreEqual(new double[] { 0, 0, 1, 1, 2, 4, 7, 13, 24, 44 }, Xbonacci.Tribonacci(new double[] { 0, 0, 1 }, 10));
            CollectionAssert.AreEqual(new double[] { 0, 1, 1, 2, 4, 7, 13, 24, 44, 81 }, Xbonacci.Tribonacci(new double[] { 0, 1, 1 }, 10));
        }
    }
}
