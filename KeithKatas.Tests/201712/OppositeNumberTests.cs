using Kata.December2017;
using NUnit.Framework;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class OppositeNumberTests
    {
        [Test]
        public void OppositeNumber_Opposite_Test_1()
        {
            Assert.AreEqual(-1, OppositeNumber.Opposite(1));
        }

        [Test]
        public void OppositeNumber_Opposite_Test_2()
        {
            Assert.AreEqual(0, OppositeNumber.Opposite(0));
        }

        [Test]
        public void OppositeNumber_Opposite_Test_3()
        {
            Assert.AreEqual(-3000, OppositeNumber.Opposite(3000));
        }

        [Test]
        public void OppositeNumber_Opposite_Test_4()
        {
            Assert.AreEqual(58000, OppositeNumber.Opposite(-58000));
        }
    }
}
