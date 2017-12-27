using KeithKatas.December2017;
using NUnit.Framework;
using System;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class PopulationGrowthTests
    {
        private static Random rnd = new Random();

        private static void Testing(int actual, int expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void PopulationGrowth_NbYear_Test1()
        {
            Console.WriteLine("Testing NbYear");
            Testing(PopulationGrowth.NbYear(1500, 5, 100, 5000), 15);
            Testing(PopulationGrowth.NbYear(1500000, 2.5, 10000, 2000000), 10);
            Testing(PopulationGrowth.NbYear(1500000, 0.25, 1000, 2000000), 94);
            Testing(PopulationGrowth.NbYear(1500000, 0.25, -1000, 2000000), 151);
            Testing(PopulationGrowth.NbYear(1500000, 0.25, 1, 2000000), 116);
            Testing(PopulationGrowth.NbYear(1500000, 0.0, 10000, 2000000), 50);
            Testing(PopulationGrowth.NbYear(1000, 2.0, 50, 1214), 4);
        }

        private static int NbYearSol(int p0, double percent, int aug, int p)
        {
            int i = 1;
            double mult = 1 + percent / 100.0;
            double prev = p0;
            while (prev < p)
            {
                double ne = Math.Floor(prev * mult + aug);
                prev = ne;
                i++;
            }
            return (i - 1);
        }

        //-----------------------
        [Test]
        public static void RandomTest()
        {
            Console.WriteLine("Random Tests");
            for (int i = 0; i < 100; i++)
            {
                int p0 = rnd.Next(10000, 15000000);
                double percent = rnd.Next(50, 1000) / 100.0;
                int aug = (int)(p0 / 200.0);
                int k = rnd.Next(5, 100);
                int p = p0 + k * aug;
                Testing(PopulationGrowth.NbYear(p0, percent, aug, p), NbYearSol(p0, percent, aug, p));
            }
        }
    }
}
