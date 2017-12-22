using KeithKatas.December2017;
using NUnit.Framework;
using System;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class SequenceTests
    {
        [Test]
        public void Sequence_SequenceSum_BasicTest()
        {
            Assert.AreEqual(12, Sequence.SequenceSum(2, 6, 2));
            Assert.AreEqual(15, Sequence.SequenceSum(1, 5, 1));
            Assert.AreEqual(5, Sequence.SequenceSum(1, 5, 3));
            Assert.AreEqual(45, Sequence.SequenceSum(0, 15, 3));
            Assert.AreEqual(0, Sequence.SequenceSum(16, 15, 3));
            Assert.AreEqual(26, Sequence.SequenceSum(2, 24, 22));
            Assert.AreEqual(2, Sequence.SequenceSum(2, 2, 2));
            Assert.AreEqual(2, Sequence.SequenceSum(2, 2, 1));
            Assert.AreEqual(35, Sequence.SequenceSum(1, 15, 3));
            Assert.AreEqual(0, Sequence.SequenceSum(15, 1, 3));
        }

        [Test]
        public void Sequence_SequenceSum_RandomTests()
        {
            Random rand = new Random();

            for (int i = 1; i <= 100; i++)
            {
                int start = rand.Next(500 * i);
                int end = rand.Next(1000 * i);
                int step = rand.Next(1, 10 * i);
                var expected = MyCode(start, end, step);
                var actual = Sequence.SequenceSum(start, end, step);
                Assert.AreEqual(expected, actual);
                Console.WriteLine($"{start} .. {end} |{step}| = {actual}");
            }
        }

        private int MyCode(int start, int end, int step) => (start > end ? 0 : ((end -= (end - start) % step) + start) * (1 + (end - start) / step) / 2);
    }
}
