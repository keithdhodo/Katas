using KeithKatas.January2018;
using NUnit.Framework;

namespace KeithKatas.Tests.January2018
{
    [TestFixture]
    public class FuelTests
    {
        [Test]
        public void Fuel_FuelPrice_BasicTests()
        {
            Assert.AreEqual(5.65, Fuel.FuelPrice(5, 1.23));
            Assert.AreEqual(18.40, Fuel.FuelPrice(8, 2.5));
            Assert.AreEqual(27.50, Fuel.FuelPrice(5, 5.6));
        }
    }
}
