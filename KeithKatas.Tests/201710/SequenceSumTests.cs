using KeithKatas.October2017;
using NUnit.Framework;

namespace KeithKatas.Tests.October2017
{
    [TestFixture]
    public class SequenceSumTests
    {
        [Test]
        public void SequenceSum_Test_0()
        {
            int input = 0;
            int[] expected = new int[] { 0 };

            int[] actual = SequenceSum.SumOfN(input);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void SequenceSum_Test_Ten()
        {
            int input = 10;
            int[] expected = new int[] { 0, 1, 3, 6, 10, 15, 21, 28, 36, 45, 55 };

            int[] actual = SequenceSum.SumOfN(input);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void SequenceSum_Test_NegativeFour()
        {
            int input = -4;
            int[] expected = new int[] { 0, -1, -3, -6, -10 };

            int[] actual = SequenceSum.SumOfN(input);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void SequenceSum_Test_Neg7()
        {
            int input = -7;
            int[] expected = new int[] { 0, -1, -3, -6, -10, -15, -21, -28 };

            int[] actual = SequenceSum.SumOfN(input);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
