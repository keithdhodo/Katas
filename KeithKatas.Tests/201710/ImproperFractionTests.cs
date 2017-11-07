using KeithKatas.October2017;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace KeithKatas.Tests.October2017
{
    [TestClass]
    public class ImproperFractionTests
    {
        [TestMethod]
        public void ImproperFraction_GetMixedNumber_SimpleTests()
        {
            Assert.AreEqual("1 7/11", ImproperFraction.GetMixedNumber("18/11"));
            Assert.AreEqual("2 3/5", ImproperFraction.GetMixedNumber("13/5"));
            Assert.AreEqual("7 5/10", ImproperFraction.GetMixedNumber("75/10"));
        }

        [TestMethod]
        public void ImproperFraction_GetMixedNumber_RandomTests()
        {
            var random = new Random();

            for (var i = 0; i < 125; i++)
            {
                var num = Math.Floor((double)(random.Next() * 100) + 11);
                var dem = Math.Floor((double)(random.Next() * 100) + 1);
                if (num % dem != 0)
                {
                    Assert.AreEqual(Solution($"{num}/{dem}"), ImproperFraction.GetMixedNumber($"{num}/{dem}"));

                }
            }
        }

        private string Solution(string fraction)
        {
            var nums = fraction.Split('/');
            var numerator = int.Parse(nums[0]);
            var demoninator = int.Parse(nums[1]);
            int wholeNum = numerator / demoninator;
            var remainder = numerator % demoninator;
            return $"{wholeNum} {remainder}/{demoninator}";
        }
    }
}
