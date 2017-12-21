using KeithKatas.October2017;
using NUnit.Framework;
using System;
using System.Linq;

namespace KeithKatas.Tests.October2017
{
    [TestFixture]
    public class ThreeForTwoTests
    {
        [Test]
        public void ThreeForTwo_ApplyDiscount_ComputeTotalFifteenItems()
        {
            var basket = new[] { 26.14m, 20.94m, 0.71m, 4.3m, 37.55m, 26.04m, 19.88m, 43.49m, 17.89m, 36.8m, 30.71m, 18.83m, 33.88m, 9.7m, 16.78m };
            var result = ThreeForTwo.ApplyDiscount(basket);
            Assert.AreEqual(243.33, result);
        }

        [Test]
        public void ThreeForTwo_ApplyDiscount_ComputeTotalRandom()
        {
            var random = new Random();
            var totalItemCount = random.Next(100) * 3;
            var basket = new decimal[totalItemCount];

            for (var i = 0; i < totalItemCount; i++)
            {
                basket[i] = (decimal)Math.Round(random.NextDouble() * 50, 2);
            }

            var result = ThreeForTwo.ApplyDiscount(basket);
            Assert.AreEqual((double)basket.OrderByDescending(price => price).Where((price, index) => (index + 1) % 3 != 0).Sum(), result);
        }
    }
}
