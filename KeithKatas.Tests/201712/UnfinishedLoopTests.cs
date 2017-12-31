using KeithKatas.December2017;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class UnfinishedLoopTests
    {
        [Test]
        public static void UnfinishedLoop_CreateList_FixedTest()
        {
            List<int> myValues = new List<int>(new int[] { 1 });
            Assert.AreEqual(myValues, UnfinishedLoop.CreateList(1));

            myValues = new List<int>(new int[] { 1, 2 });
            Assert.AreEqual(myValues, UnfinishedLoop.CreateList(2));

            myValues = new List<int>(new int[] { 1, 2, 3, 4, 5, 6 });
            Assert.AreEqual(myValues, UnfinishedLoop.CreateList(6));
        }

        [Test]
        public static void UnfinishedLoop_CreateList_RandomTests()
        {
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                int num = r.Next(100) + 1;
                Assert.AreEqual(Solution(num), UnfinishedLoop.CreateList(num));
            }
        }

        private static List<int> Solution(int num)
        {
            return Enumerable.Range(1, num).ToList();
        }
    }
}
