using KeithKatas.December2017;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class PrimeTests
    {
        [Test]
        public void Prime_IsPrime_SampleTest()
        {
            Assert.IsFalse(Prime.IsPrime(0));
            Assert.IsFalse(Prime.IsPrime(1));
            Assert.IsTrue(Prime.IsPrime(2));
            Assert.IsFalse(Prime.IsPrime(6));
            Assert.IsFalse(Prime.IsPrime(8));
            Assert.IsFalse(Prime.IsPrime(9));
            Assert.IsFalse(Prime.IsPrime(-1));
            Assert.IsTrue(Prime.IsPrime(5099));
        }

        [Test, Description("Random Tests")]
        public void Prime_IsPrime_RandomTests()
        {
            var rnd = new Random();
            const int Tests = 1000;

            for (int i = 0; i < Tests; ++i)
            {
                int n = rnd.Next();

                bool expected = IsPrime(n);
                bool actual = Prime.IsPrime(n);

                Assert.AreEqual(expected, actual);
            }
        }

        private static Dictionary<int, bool> primesMemo = new Dictionary<int, bool>();

        private static bool IsPrime(int n)
        {
            // Memo Check
            if (primesMemo.ContainsKey(n)) { return primesMemo[n]; }

            double sqrt = Math.Sqrt(n);
            for (double i = 2; i <= sqrt; ++i)
            {
                if (n % i == 0)
                {
                    primesMemo.Add(n, false);
                    return false;
                }
            }

            primesMemo.Add(n, n >= 2);
            return n >= 2;
        }
    }
}
