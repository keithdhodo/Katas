using KeithKatas.January2018;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KeithKatas.Tests.January2018
{
    [TestFixture]
    public class SmallestIntegerTests
    {
        [Test]
        public static void SmallestInteger_FindSmallestInt_FixedTest1()
        {
            Assert.AreEqual(11, SmallestInteger.FindSmallestInt(new int[] { 78, 56, 232, 12, 11, 43 }));
        }

        [Test]
        public static void SmallestInteger_FindSmallestInt_FixedTest2()
        {
            Assert.AreEqual(-33, SmallestInteger.FindSmallestInt(new int[] { 78, 56, -2, 12, 8, -33 }));
        }

        private static int Solution(int[] args)
        {
            return new List<int>(args).OrderBy(x => x).FirstOrDefault();
        }

        [Test]
        public static void SmallestInteger_FindSmallestInt_RandomTest([Random(0, 10, 50)]int min)
        {
            Random r = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < 99; i++)
            {
                list.Add(r.Next(90) + 10);
            }
            list.Add(min);
            int[] args = list.ToArray();
            Assert.AreEqual(Solution(args), SmallestInteger.FindSmallestInt(args));
        }
    }
}
