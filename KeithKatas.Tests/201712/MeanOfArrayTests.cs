using Kata.December2017;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class MeanOfArrayTests
    {
        [Test]
        [TestCase(new int[] { 2, 2, 2, 2 }, ExpectedResult = 2)]
        [TestCase(new int[] { 5, 10 }, ExpectedResult = 7)]
        public static int MeanOfArray_GetAverage_FixedTest(int[] marks)
        {
            return MeanOfArray.GetAverage(marks);
        }

        private static int Solution(int[] marks)
        {
            return (int)Math.Floor(new List<int>(marks).Average());
        }

        [Test]
        public static void MeanOfArray_GetAverage_RandomTest([Random(1, 10, 98)]int x)
        {
            List<int> l = new List<int>();
            Random r = new Random();
            for (int i = 0; i < x; i++)
            {
                l.Add(r.Next(100) + 1);
            }
            int[] arr = l.ToArray();
            Assert.AreEqual(Solution(arr), MeanOfArray.GetAverage(arr), string.Format("Should work for {0}", string.Join(", ", l.ToArray())));
        }
    }
}
