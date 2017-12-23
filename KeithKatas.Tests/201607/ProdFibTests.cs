using KeithKatas.July2016;
using NUnit.Framework;

namespace Sandbox.July2016
{
    [TestFixture]
    public class ProdFibTests
    {
        [Test]
        public void ProdFibTest1()
        {
            ulong[] r = new ulong[] { 55, 89, 1 };
            CollectionAssert.AreEqual(r, ProdFib.ProductFib(4895));
        }

        [Test]
        public void ProdFibTest2()
        {
            ulong[] r = new ulong[] { 21, 34, 1 };
            CollectionAssert.AreEqual(r, ProdFib.ProductFib(714));
        }

        [Test]
        public void ProdFibTest3()
        {
            ulong[] r = new ulong[] { 34, 55, 0 };
            CollectionAssert.AreEqual(r, ProdFib.ProductFib(800));
        }

        [Test]
        public void ProdFibTest4()
        {
            ulong[] r = new ulong[] { 610, 987, 1 };
            CollectionAssert.AreEqual(r, ProdFib.ProductFib(602070));
        }
        
        [Test]
        public void ProdFibTest5()
        {
            ulong[] r = new ulong[] { 610, 987, 1 };
            CollectionAssert.AreEqual(r, ProdFib.ProductFib(602070));
        }
    }
}
