using KeithKatas.December2017;
using NUnit.Framework;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class AgeTests
    {
        [Test]
        public void Age_GetAge_BasicTests()
        {
            Assert.AreEqual(0, Age.GetAge("0 years old"));
            Assert.AreEqual(1, Age.GetAge("1 years old"));
            Assert.AreEqual(2, Age.GetAge("2 years old"));
            Assert.AreEqual(3, Age.GetAge("3 years old"));
            Assert.AreEqual(4, Age.GetAge("4 years old"));
            Assert.AreEqual(5, Age.GetAge("5 years old"));
            Assert.AreEqual(6, Age.GetAge("6 years old"));
            Assert.AreEqual(7, Age.GetAge("7 years old"));
            Assert.AreEqual(8, Age.GetAge("8 years old"));
            Assert.AreEqual(9, Age.GetAge("9 years old"));
        }
    }
}
