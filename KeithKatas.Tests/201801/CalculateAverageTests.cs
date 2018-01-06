using KeithKatas.January2018;
using NUnit.Framework;
using System;
using System.Linq;

namespace KeithKatas.Tests.January2018
{
    [TestFixture]
    public class CalculateAverageTests
    {
        private Random random = new Random();

        private double FindAverage(double[] array) { return array.Average(); }

        private double[] GenerateArray(int size)
        {
            var array = new double[size];
            for (int i = 0; i < size; ++i)
                array[i] = random.NextDouble() * 2000 - 1000;
            return array;
        }

        [Test]
        public void CalculateAverage_FindAverage_ExampleTest()
        {
            double[] array = new double[] { 17, 16, 16, 16, 16, 15, 17, 17, 15, 5, 17, 17, 16 };
            Assert.AreEqual(200.0 / 13.0, CalculateAverage.FindAverage(array));

            // Should return 0 on empty array
            Assert.AreEqual(0, CalculateAverage.FindAverage(new double[] { }));
        }

        [Test]
        public void CalculateAverage_FindAverage_RandomTests()
        {
            for (int now = 0; now < 25; ++now)
            {
                var array = GenerateArray(random.Next(1, 100));
                Assert.AreEqual(this.FindAverage(array), CalculateAverage.FindAverage(array));
            }
        }

        [Test]
        public void CalculateAverage_FindAverage_EdgeTests()
        {
            var array = new double[] { 0, 0, 0, 0, 0 };
            Assert.AreEqual(0, CalculateAverage.FindAverage(array));

            array = new double[] { };
            Assert.AreEqual(0, CalculateAverage.FindAverage(array));
        }
    }
}
