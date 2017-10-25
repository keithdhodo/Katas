using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata;
using System.Dynamic;

namespace Sandbox
{
    [TestClass]
    public class GetLengthTests
    {
        [TestMethod]
        public void GetLengthTestsFirstTest()
        {
            int[] a = new int[] { 1, 2, 3, 4, 5 };
            Assert.AreEqual(5, new GetLength().GetObjectLength(a));
        }

        [TestMethod]
        public void GetLengthTestsSecondTest()
        {
            string a = "abcde";
            Assert.AreEqual(5, new GetLength().GetObjectLength(a));
        }

        [TestMethod]
        public void GetLengthTestsThirdTest()
        {
            object a = new { Length = 5, Width = 2 };
            Assert.AreEqual(5, new GetLength().GetObjectLength(a));
        }

        [TestMethod]
        public void GetLengthTestsFourthTest()
        {
            dynamic a = new ExpandoObject();
            a.Length = 5;
            var getLegnth = new GetLength();
            Assert.AreEqual(5, getLegnth.GetObjectLength(a));
        }
    }
}
