using KeithKatas.January2018;
using NUnit.Framework;
using System;

namespace KeithKatas.Tests.January2018
{
    [TestFixture]
    public class StringToNumberTests
    {
        [Test]
        public void StringToNumber_ConvertStringToNumber_Test1()
        {
            Assert.AreEqual(1234, StringToNumber.ConvertStringToNumber("1234"));
        }

        [Test]
        public void StringToNumber_ConvertStringToNumber_Test2()
        {
            Assert.AreEqual(605, StringToNumber.ConvertStringToNumber("605"));
        }

        [Test]
        public void StringToNumber_ConvertStringToNumber_Test3()
        {
            Assert.AreEqual(1405, StringToNumber.ConvertStringToNumber("1405"));
        }

        [Test]
        public void StringToNumber_ConvertStringToNumber_Test4()
        {
            Assert.AreEqual(-7, StringToNumber.ConvertStringToNumber("-7"));
        }

        [Test]
        public void StringToNumber_ConvertStringToNumber_ShouldWorkForRandomNumbers()
        {
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                int num = r.Next(1000) - 500 + 1;
                Assert.AreEqual(int.Parse(num.ToString()), StringToNumber.ConvertStringToNumber(num.ToString()), String.Format("Should work for {0}", num));
            }
        }
    }
}
