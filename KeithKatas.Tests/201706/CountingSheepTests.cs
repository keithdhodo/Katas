using Kata.June2017;
using NUnit.Framework;
using System;
using System.Linq;

namespace KataTests.June2017
{
    [TestFixture]
    public class CountingSheepTests
    {
        private static Random ran;

        [OneTimeSetUp]
        public void TestInitialize()
        {
            ran = new Random();
        }

        [TestCase]
        public void CountingSheepBasicTest1()
        {
            var kata = new CountingSheep();
            int[] friday = new int[] { 1, 2 };
            int[] saturday = new int[] { 3, 4 };
            NUnit.Framework.Assert.AreEqual(5, kata.LostSheep(friday, saturday, 15));
        }

        [TestCase]
        public void CountingSheepBasicTest2()
        {
            var kata = new CountingSheep();
            int[] friday = new int[] { 3, 1, 2 };
            int[] saturday = new int[] { 4, 5 };
            NUnit.Framework.Assert.AreEqual(6, kata.LostSheep(friday, saturday, 21));
        }

        [TestCase]
        public void CountingSheepBasicTest3()
        {
            var kata = new CountingSheep();
            int[] friday = new int[] { 5, 1, 4 };
            int[] saturday = new int[] { 5, 4 };
            NUnit.Framework.Assert.AreEqual(10, kata.LostSheep(friday, saturday, 29));
        }

        [TestCase]
        public void CountingSheepAdvancedTest1()
        {
            var kata = new CountingSheep();
            int[] friday = new int[] { 11, 23, 3, 4, 15 };
            int[] saturday = new int[] { 7, 14, 9, 21, 15 };
            NUnit.Framework.Assert.AreEqual(178, kata.LostSheep(friday, saturday, 300));
        }
        [TestCase]
        public void CountingSheepAdvancedTest2()
        {
            var kata = new CountingSheep();
            int[] friday = new int[] { 2, 7, 13, 17 };
            int[] saturday = new int[] { 23, 56, 44, 12, 1, 2, 1 };
            NUnit.Framework.Assert.AreEqual(77, kata.LostSheep(friday, saturday, 255));
        }
        [TestCase]
        public void CountingSheepAdvancedTest3()
        {
            var kata = new CountingSheep();
            int[] friday = new int[] { 2, 5, 8 };
            int[] saturday = new int[] { 11, 23, 3, 4, 15, 112, 12, 4 };
            NUnit.Framework.Assert.AreEqual(156, kata.LostSheep(friday, saturday, 355));
        }
        [TestCase]
        public void CountingSheepAdvancedTest4()
        {
            var kata = new CountingSheep();
            int[] friday = new int[] { 1, 1, 1, 2, 1, 2 };
            int[] saturday = new int[] { 2, 1, 2, 1, 2, 1 };
            NUnit.Framework.Assert.AreEqual(13, kata.LostSheep(friday, saturday, 30));
        }
        [TestCase]
        public void CountingSheepAdvancedTest5()
        {
            var kata = new CountingSheep();
            int[] friday = new int[] { 5, 10, 15 };
            int[] saturday = new int[] { 11, 23, 3, 4, 15 };
            NUnit.Framework.Assert.AreEqual(3, kata.LostSheep(friday, saturday, 89));
        }
        [TestCase]
        public void CountingSheepAdvancedTest6()
        {
            var kata = new CountingSheep();
            int[] friday = new int[] { 3, 6, 9, 12 };
            int[] saturday = new int[] { 3, 2, 1, 2, 3, 1 };
            NUnit.Framework.Assert.AreEqual(2, kata.LostSheep(friday, saturday, 44));
        }

        [TestCase]
        [TestCase]
        [TestCase]
        [TestCase]
        [TestCase]
        [TestCase]
        [TestCase]
        [TestCase]
        [TestCase]
        [TestCase]
        [TestCase]
        [TestCase]
        [TestCase]
        [TestCase]
        [TestCase]
        [TestCase]
        [TestCase]
        [TestCase]
        [TestCase]
        [TestCase]
        public void CountingSheepRandomTest()
        {
            var kata = new CountingSheep();
            int n1 = ran.Next(1, 50);
            int n2 = ran.Next(1, 50);
            int lost = ran.Next(1, 40);
            int[] friday = new int[n1];
            int[] saturday = new int[n2];
            for (int iii = 0; iii < n1; iii++)
            {
                friday[iii] = ran.Next(1, 50);
            }
            for (int iii = 0; iii < n2; iii++)
            {
                saturday[iii] = ran.Next(1, 50);
            }
            int total = friday.Sum() + saturday.Sum() + lost;
            NUnit.Framework.Assert.AreEqual(lost, kata.LostSheep(friday, saturday, total));
        }
    }
}
