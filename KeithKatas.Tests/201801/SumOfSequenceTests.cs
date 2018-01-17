using KeithKatas.January2018;
using NUnit.Framework;
using System;

namespace KeithKatas.Tests.January2018
{
    [TestFixture]
    public class SumOfSequenceTests
    {
        [Test]
        public void SumOfSequence_ShowSequence_BasicTests()
        {
            Assert.AreEqual("0+1+2+3+4+5+6 = 21", SumOfSequence.ShowSequence(6));
            Assert.AreEqual("0+1+2+3+4+5+6+7 = 28", SumOfSequence.ShowSequence(7));
        }

        [Test]
        public void SumOfSequence_ShowSequence_NegativeAndZeroTests()
        {
            Assert.AreEqual("0=0", SumOfSequence.ShowSequence(0));
            Assert.AreEqual("-1<0", SumOfSequence.ShowSequence(-1));
            Assert.AreEqual("-10<0", SumOfSequence.ShowSequence(-10));
        }

        [Test]
        public void SumOfSequence_ShowSequence_RandomTests()
        {
            var rand = new Random();

            Func<int, string> myShowSequence = delegate (int n)
            {
                if (n == 0)
                {
                    return "0=0";
                }
                if (n < 0)
                {
                    return n + "<0";
                }
                var sum = 0;
                var numbers = new int[n + 1];
                for (int i = 0; i <= n; i++)
                {
                    sum += i;
                    numbers[i] = i;
                }

                return string.Join("+", numbers) + " = " + sum;
            };

            for (int r = 0; r < 40; r++)
            {
                var number = rand.Next(0, 1000);
                Assert.AreEqual(myShowSequence(number), SumOfSequence.ShowSequence(number));
            }
        }
    }
}
