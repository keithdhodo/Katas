using NUnit.Framework;

namespace AndrewKata.Tests
{
    [TestFixture]
    public class RandomNumberGeneratorTests
    {
        [Test]
        public void GenerateRandomNumberTest()
        {
            var kata1 = new RandomNumberGenerator();
            var kata2 = new RandomNumberGenerator();
            Assert.AreNotEqual(kata1.GenerateRandomNumber(), kata2.GenerateRandomNumber());
        }
    }
}