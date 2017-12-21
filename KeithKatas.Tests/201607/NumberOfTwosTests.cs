using KeithKatas.July2016;
using NUnit.Framework;

namespace Sandbox._201607
{
    [TestFixture]
    public class NumberOfTwosTests
    {
        [Test]
        public void NumberOfTwosTest24()
        {
            Assert.AreEqual(3, NumberOfTwos.TwoCount(24));
        }

        [Test]
        public void NumberOfTwosTest17280()
        {
            Assert.AreEqual(7, NumberOfTwos.TwoCount(17280));
        }

        [Test]
        public void NumberOfTwosTest222222222()
        {
            Assert.AreEqual(1, NumberOfTwos.TwoCount(222222222));
        }

        [Test]
        public void NumberOfTwosTest256()
        {
            Assert.AreEqual(8, NumberOfTwos.TwoCount(256));
        }

        [Test]
        public void NumberOfTwosTest0()
        {
            Assert.AreEqual(0, NumberOfTwos.TwoCount(1));
        }

        [Test]
        public void NumberOfTwosTest7()
        {
            Assert.AreEqual(0, NumberOfTwos.TwoCount(7));
        }

        [Test]
        public void NumberOfTwosTest84934656()
        {
            Assert.AreEqual(20, NumberOfTwos.TwoCount(84934656));
        }
    }
}
