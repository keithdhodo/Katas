using KeithKatas.July2016;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sandbox._201607
{
    [TestClass]
    public class ProdFibTests
    {
        [TestMethod]
        public void ProdFibTest1()
        {
            ulong[] r = new ulong[] { 55, 89, 1 };
            CollectionAssert.AreEqual(r, ProdFib.productFib(4895));
        }

        [TestMethod]
        public void ProdFibTest2()
        {
            ulong[] r = new ulong[] { 21, 34, 1 };
            CollectionAssert.AreEqual(r, ProdFib.productFib(714));
        }

        [TestMethod]
        public void ProdFibTest3()
        {
            ulong[] r = new ulong[] { 34, 55, 0 };
            CollectionAssert.AreEqual(r, ProdFib.productFib(800));
        }

        [TestMethod]
        public void ProdFibTest4()
        {
            ulong[] r = new ulong[] { 610, 987, 1 };
            CollectionAssert.AreEqual(r, ProdFib.productFib(602070));
        }

        [Ignore]
        [TestMethod]
        public void ProdFibTest5()
        {
            ulong[] r = new ulong[] { 610, 987, 1 };
            CollectionAssert.AreEqual(r, ProdFib.productFib(447577));
        }
    }
}
