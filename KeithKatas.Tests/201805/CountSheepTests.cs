using KeithKatas.May2018;
using NUnit.Framework;

namespace KeithKatas.Tests.May2018
{
    [TestFixture]
    public class CountSheepTests
    {
        [Test]
        public void SampleTest()
        {
            var sheeps = new bool[] { true, false, true };

            Assert.AreEqual(2, Arrays.CountSheep(sheeps));
        }

        [Test]
        public void NumberOfTruesInArrayReturned()
        {
            var sheeps = new bool[] { true, false, true };

            Assert.AreEqual(2, Arrays.CountSheep(sheeps));

            sheeps = new bool[] { true, false, true, true, false, true, true, false, true };

            Assert.AreEqual(6, Arrays.CountSheep(sheeps));

            sheeps = new bool[] { true, true, true, true, true, true, true, true, true };

            Assert.AreEqual(9, Arrays.CountSheep(sheeps));

            sheeps = new bool[] { false, false, false, false, false, false, false, false, false, false, false, false };

            Assert.AreEqual(0, Arrays.CountSheep(sheeps));
        }
    }
}
