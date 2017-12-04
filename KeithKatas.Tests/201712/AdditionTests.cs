using Kata.December2017;
using NUnit.Framework;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class AdditionTests
    {
        [Test]
        public void Addition_Sum_Positives()
        {
            Assert.AreEqual(16, Addition.Sum(new[] { 6, 2, 1, 8, 10 }));
        }
    }
}
