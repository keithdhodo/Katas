using Kata.November2017;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeithKatas.Tests.November2017
{
    [TestFixture]
    public class StrayNumberTests
    {
        [Test]
        public void StrayNumber_Stray_SimpleArray1()
        {
            Assert.AreEqual(2, StrayNumber.Stray(new int[] {1, 1, 2}));
        }

        [Test]
        public void StrayNumber_Stray_SimpleArray2()
        {
            Assert.AreEqual(3, StrayNumber.Stray(new int[] { 17, 17, 3, 17, 17, 17, 17 }));
        }

        [Test]
        public void StrayNumber_Stray_FirstItem()
        {
            Assert.AreEqual(8, StrayNumber.Stray(new int[] { 8, 1, 1, 1, 1, 1, 1 }));
        }

        [Test]
        public void StrayNumber_Stray_LastItem()
        {
            Assert.AreEqual(0, StrayNumber.Stray(new int[] { 1, 1, 1, 1, 1, 1, 0 }));
        }

        [Test]
        public void StrayNumber_Stray_MiddleItem()
        {
            Assert.AreEqual(7, StrayNumber.Stray(new int[] { 0, 0, 0, 7, 0, 0, 0 }));
        }

        [Test]
        public void StrayNumber_Stray_SimpleArray3()
        {
            Assert.AreEqual(-6, StrayNumber.Stray(new int[] { -21, -21, -21, -21, -6, -21, -21 }));
        }

        //[Test]
        //public void StrayNumber_Stray_RandomSmallArray()
        //{
        //    int strayNumber = SolutionHelper.RandomInt(-10000, 10000);
        //    int[] array = SolutionHelper.ValidRandomArray(101, strayNumber);
        //    Assert.AreEqual(strayNumber, StrayNumber.Stray(array));
        //}

        //[Test]
        //public void StrayNumber_Stray_RandomBigArray()
        //{
        //    int strayNumber = SolutionHelper.RandomInt(-10000, 10000);
        //    int[] array = SolutionHelper.ValidRandomArray(15273, strayNumber);
        //    Assert.AreEqual(strayNumber, StrayNumber.Stray(array));
        //}
    }
}
