using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata.August2016;
using System.Diagnostics;
using System.Linq;

namespace Sandbox.August2016
{
    [TestClass]
    public class ProductOfLargestPairTests
    {
        [TestMethod]
        public void ProductOfLargestPairTest1()
        {
            Assert.AreEqual(218842, ProductOfLargestPair.MaxProduct(new int[] { 56, 335, 195, 443, 6, 494, 252 }));
            Assert.AreEqual(194740, ProductOfLargestPair.MaxProduct(new int[] { 154, 428, 455, 346 }));
            Assert.AreEqual(187827, ProductOfLargestPair.MaxProduct(new int[] { 39, 135, 47, 275, 37, 108, 265, 457, 2, 133, 316, 330, 153, 253, 321, 411 }));
            Assert.AreEqual(87984, ProductOfLargestPair.MaxProduct(new int[] { 136, 376, 10, 146, 105, 63, 234 }));
            Assert.AreEqual(218536, ProductOfLargestPair.MaxProduct(new int[] { 354, 463, 165, 62, 472, 53, 347, 293, 252, 378, 420, 398, 255, 89 }));
            Assert.AreEqual(192672, ProductOfLargestPair.MaxProduct(new int[] { 346, 446, 26, 425, 432, 349, 123, 269, 285, 93, 75, 14 }));
            Assert.AreEqual(95680, ProductOfLargestPair.MaxProduct(new int[] { 134, 320, 266, 299 }));
            Assert.AreEqual(139496, ProductOfLargestPair.MaxProduct(new int[] { 114, 424, 53, 272, 128, 215, 25, 329, 272, 313, 100, 24, 252 }));
            Assert.AreEqual(174750, ProductOfLargestPair.MaxProduct(new int[] { 375, 56, 337, 466, 203 }));
        }

        [Ignore]
        [TestMethod]
        public void ProductOfLargestPairRandom()
        {
            var rand = new Random();
            var LIMIT = 1000;

            Func<int[], int> myMaxProduct = delegate (int[] array)
            {
                var max = array[0];
                var preMax = array[0];
                for (var i = 1; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        preMax = max;
                        max = array[i];
                    }
                    else
                    {
                        if (array[i] > preMax)
                        {
                            preMax = array[i];
                        }
                    }
                }

                return max * preMax;
            };

            Func<int[], int, int[]> sample = delegate (int[] array, int size)
            {
                var i = array.Length;
                int temp;

                while (i-- > 0)
                {
                    var index = rand.Next(0, i + 1);
                    temp = array[index];
                    array[index] = array[i];
                    array[i] = temp;
                }
                return array.Take(size).ToArray();
            };

            var sw = Stopwatch.StartNew();

            for (var i = 0; i < 199; i++)
            {
                var small = sample(Enumerable.Range(1, 5000).ToArray(), 500);
                var big = sample(Enumerable.Range(5001, 20000).ToArray(), 10000);
                var arr = small.Concat(big).ToArray();

                Assert.AreEqual(myMaxProduct(arr), ProductOfLargestPair.MaxProduct(arr));
            }
            for (var i = 0; i < 200; i++)
            {
                var small = sample(Enumerable.Range(1, 5000).ToArray(), 500);
                var big = sample(Enumerable.Range(10001, 40000).ToArray(), 10000);
                var arr = small.Concat(big).ToArray();

                Assert.AreEqual(myMaxProduct(arr), ProductOfLargestPair.MaxProduct(arr));
            }

            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds + " ms");
            Assert.IsTrue(sw.ElapsedMilliseconds < LIMIT, "Too slow! Speed must be lower than " + LIMIT + " ms. Maybe try a different approach?");
        }
    }
}
