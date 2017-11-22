using Kata.November2017;
using NUnit.Framework;
using System;

namespace KeithKatas.Tests.November2017
{
    [TestFixture]
    public class BonusCalculatorTests
    {
        [Test]
        public void BonusCalculator_BonusTime_BasicTest()
        {
            StringAssert.AreEqualIgnoringCase("$100000", BonusCalculator.BonusTime(10000, true));
            StringAssert.AreEqualIgnoringCase("$250000", BonusCalculator.BonusTime(25000, true));
            StringAssert.AreEqualIgnoringCase("$10000", BonusCalculator.BonusTime(10000, false));
            StringAssert.AreEqualIgnoringCase("$60000", BonusCalculator.BonusTime(60000, false));
            StringAssert.AreEqualIgnoringCase("$20", BonusCalculator.BonusTime(2, true));
            StringAssert.AreEqualIgnoringCase("$78", BonusCalculator.BonusTime(78, false));
            StringAssert.AreEqualIgnoringCase("$678900", BonusCalculator.BonusTime(67890, true));
        }

        [Test]
        public void BonusCalculator_BonusTime_RandomTest([Values(1)] int a, [Random(-1, 1, 40)] double d)
        {
            RgTest rg = new RgTest((int)d * 10000);
            int salary = rg.Salary();
            bool bonus = rg.Bonus();
            string output = "";
            if (bonus)
            {
                output = "$" + (salary * 10);
            }
            else
            {
                output = "$" + salary;
            }
            StringAssert.AreEqualIgnoringCase(output, BonusCalculator.BonusTime(salary, bonus));
        }

        public class RgTest
        {
            static Random _random;
            private static int _counter;
            public RgTest(int seed)
            {
                _counter = _counter + 1;
                _random = new Random(seed + _counter);
            }

            public int Salary()
            {
                return _random.Next(1, 102);
            }

            public bool Bonus()
            {
                return _random.Next(0, 2) < 1;
            }
        }
    }
}
