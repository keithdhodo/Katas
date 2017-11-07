using KeithKatas.November2017;
using NUnit.Framework;
using System;

namespace KeithKatas.Tests.November2017
{
    [TestFixture]
    public class EasterSundayTests
    {
        EasterSunday instance = new EasterSunday();

        [Test]
        public void Test1582()
        {
            int year = 1582;
            Assert.AreEqual(new DateTime(year, 04, 18), instance.CalculateEasterSunday(year));
        }

        [Test]
        public void Test1612()
        {
            int year = 1612;
            Assert.AreEqual(new DateTime(year, 04, 22), instance.CalculateEasterSunday(year));
        }

        [Test]
        public void Test1789()
        {
            int year = 1789;
            Assert.AreEqual(new DateTime(year, 04, 12), instance.CalculateEasterSunday(year));
        }

        [Test]
        public void Test1931()
        {
            int year = 1931;
            Assert.AreEqual(new DateTime(year, 04, 05), instance.CalculateEasterSunday(year));
        }

        [Test]
        public void Test1999()
        {
            int year = 1999;
            Assert.AreEqual(new DateTime(year, 04, 04), instance.CalculateEasterSunday(year));
        }

        [Test]
        public void Test2005()
        {
            int year = 2005;
            Assert.AreEqual(new DateTime(year, 03, 27), instance.CalculateEasterSunday(year));
        }
    }
}
