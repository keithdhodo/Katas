using KeithKatas.January2018;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeithKatas.Tests.January2018
{
    [TestFixture]
    public class FoldTests
    {
        private static Random rnd = new Random();

        private static int? solution(double distance)
        {
            // return null if distance is negative or 0
            if (distance <= 0) { return null; }

            const double initialThickness = 0.0001;

            return (int)Math.Max(Math.Ceiling(Math.Log(distance / initialThickness, 2)), 0);
        }

        [Test]
        public void Fold_FoldTo_Basic_Test()
        {
            Assert.AreEqual(42, Fold.FoldTo(384000000));
        }

        [Test]
        public void Fold_FoldTo_Basic_Test0()
        {
            Assert.AreEqual(null, Fold.FoldTo(0));
        }

        [Test, Description("Random Tests (1000 assertions)")]
        public void Random_Test()
        {
            Stopwatch sw = new Stopwatch();
            const int tests = 1000;

            for (int i = 0; i < tests; ++i)
            {
                double distance, random = rnd.NextDouble();
                if (random < 0.1) { distance = 0; }
                else { distance = 0.0001 * Math.Pow(2, rnd.NextDouble() * (128 + 22) - 22); }
                if (random > 0.9) { distance *= -1; }
                Console.WriteLine("Distance: {0}m", distance);

                int? expected = solution(distance);

                sw.Start();
                int? actual = Fold.FoldTo(distance);
                sw.Stop();

                Assert.AreEqual(expected, actual);
            }

            Console.WriteLine("\nRandom tests passed!\nUser code execution time was {0} milliseconds over {1} assertions.", sw.Elapsed.TotalMilliseconds, tests);
        }
    }
}
