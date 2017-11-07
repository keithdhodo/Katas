using KeithKatas.July2016;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sandbox._201607
{
    [TestClass]
    public class NumberOfTwosTests
    {
        [TestMethod]
        public void NumberOfTwosTest24()
        {
            Assert.AreEqual(3, NumberOfTwos.TwoCount(24));
        }

        [TestMethod]
        public void NumberOfTwosTest17280()
        {
            Assert.AreEqual(7, NumberOfTwos.TwoCount(17280));
        }

        [TestMethod]
        public void NumberOfTwosTest222222222()
        {
            Assert.AreEqual(1, NumberOfTwos.TwoCount(222222222));
        }

        [TestMethod]
        public void NumberOfTwosTest256()
        {
            Assert.AreEqual(8, NumberOfTwos.TwoCount(256));
        }

        [TestMethod]
        public void NumberOfTwosTest0()
        {
            Assert.AreEqual(0, NumberOfTwos.TwoCount(1));
        }

        [TestMethod]
        public void NumberOfTwosTest7()
        {
            Assert.AreEqual(0, NumberOfTwos.TwoCount(7));
        }

        [TestMethod]
        public void NumberOfTwosTest84934656()
        {
            Assert.AreEqual(20, NumberOfTwos.TwoCount(84934656));
        }
    }
}
