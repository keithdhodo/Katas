﻿using Kata.December2017;
using NUnit.Framework;
using System;
using System.Linq;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class SquareOrSquareRootTests
    {
        [Test]
        public void SquareOrSquareRoot_SquareSquareRoot_BasicTests()
        {
            var input = new int[] { 4, 3, 9, 7, 2, 1 };
            var expected = new int[] { 2, 9, 3, 49, 4, 1 };
            Assert.AreEqual(string.Join(",", expected), string.Join(",", SquareOrSquareRoot.SquareSquareRoot(input)));

            input = new int[] { 100, 101, 5, 5, 1, 1 };
            expected = new int[] { 10, 10201, 25, 25, 1, 1 };
            Assert.AreEqual(string.Join(",", expected), string.Join(",", SquareOrSquareRoot.SquareSquareRoot(input)));

            input = new int[] { 1, 2, 3, 4, 5, 6 };
            expected = new int[] { 1, 4, 9, 2, 25, 36 };
            Assert.AreEqual(string.Join(",", expected), string.Join(",", SquareOrSquareRoot.SquareSquareRoot(input)));
        }

        [Test]
        public void SquareOrSquareRoot_SquareSquareRoot_RandomTests()
        {
            var rand = new Random();

            Func<int[], int[]> mySquareOrSquareRoot = delegate (int[] array)
            {
                return array.Select(a =>
                {
                    var sqrt = Math.Sqrt(a);
                    if (sqrt == (int)sqrt)
                    {
                        return (int)sqrt;
                    }
                    return a * a;
                }).ToArray();
            };

            for (int r = 0; r < 30; r++)
            {
                var array = Enumerable.Range(0, rand.Next(3, 20)).Select(a => rand.Next(1, 101)).ToArray();
                var expected = mySquareOrSquareRoot(array);

                Assert.AreEqual(string.Join(",", expected), string.Join(",", SquareOrSquareRoot.SquareSquareRoot(array)));
            }
        }
    }
}
