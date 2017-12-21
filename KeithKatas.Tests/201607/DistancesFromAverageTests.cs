using KeithKatas.July2016;
using NUnit.Framework;

namespace Sandbox._201607
{
    [TestFixture]
    public class DistancesFromAverageTests
    {
        [Test]
        public void DistancesFromAverageTest1()
        {
            CollectionAssert.AreEqual(new[] { 4.2, -35.8, -2.8, 23.2, 11.2 }, DistancesFromAvg.DistancesFromAverage(new[] { 55, 95, 62, 36, 48 }));
            CollectionAssert.AreEqual(new[] { 0.0, 0.0, 0.0, 0.0, 0.0 }, DistancesFromAvg.DistancesFromAverage(new[] { 1, 1, 1, 1, 1 }));
            CollectionAssert.AreEqual(new[] { -1.0, 1.0, -1.0, 1.0, -1.0, 1.0 }, DistancesFromAvg.DistancesFromAverage(new[] { 1, -1, 1, -1, 1, -1 }));
            CollectionAssert.AreEqual(new[] { -0.8, 1.2, -0.8, 1.2, -0.8 }, DistancesFromAvg.DistancesFromAverage(new[] { 1, -1, 1, -1, 1 }));
            CollectionAssert.AreEqual(new[] { -2.0, 2.0 }, DistancesFromAvg.DistancesFromAverage(new[] { 2, -2 }));
            CollectionAssert.AreEqual(new[] { 0.0 }, DistancesFromAvg.DistancesFromAverage(new[] { 1 }));
            CollectionAssert.AreEqual(new[] { 6197.6, 6385.6, -26111.4, 6673.6, 6854.6 }, DistancesFromAvg.DistancesFromAverage(new[] { 123, -65, 32432, -353, -534 }));
        }
    }
}
