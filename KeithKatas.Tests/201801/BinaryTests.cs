using KeithKatas.January2018;
using NUnit.Framework;
using System;
using System.Linq;

namespace KeithKatas.Tests.January2018
{
    [TestFixture]
    public class BinaryTests
    {
        public static int binaryArrayToNumberSolution(int[] BinaryArray)
        {
            BinaryArray = BinaryArray.Reverse().ToArray();
            for (int i = 1; i < BinaryArray.Length; i++) BinaryArray[0] += (BinaryArray[i] == 1) ? (int)Math.Pow(2, i) : 0;
            return BinaryArray[0];
        }

        int[] Test1 = new int[] {0,0,0,0};
        int[] Test2 = new int[] {1,1,1,1};
        int[] Test3 = new int[] {0,1,1,0};
        int[] Test4 = new int[] {0,1,0,1};

        [Test]
        public void Binary_BinaryArrayToNumber_BasicTesting()
        {
          Assert.AreEqual(0 , Binary.BinaryArrayToNumber(Test1));
          Assert.AreEqual(15 , Binary.BinaryArrayToNumber(Test2));
          Assert.AreEqual(6 , Binary.BinaryArrayToNumber(Test3));
          Assert.AreEqual(5 , Binary.BinaryArrayToNumber(Test4));
        }

        int[] Test5 = new int[] { 1, 0, 1, 1 };
        int[] Test6 = new int[] { 1, 0, 0, 1 };
        int[] Test7 = new int[] { 0, 0, 0, 1 };
        int[] Test8 = new int[] { 1, 0, 1, 0 };
        int[] Test9 = new int[] { 1, 0, 0, 0 };
        int[] Test10 = new int[] { 0, 1, 0, 0 };
        [Test]
        public void Binary_BinaryArrayToNumber_MoreTests()
        {
            Assert.AreEqual(11, Binary.BinaryArrayToNumber(Test5));
            Assert.AreEqual(9, Binary.BinaryArrayToNumber(Test6));
            Assert.AreEqual(1, Binary.BinaryArrayToNumber(Test7));
            Assert.AreEqual(10, Binary.BinaryArrayToNumber(Test8));
            Assert.AreEqual(8, Binary.BinaryArrayToNumber(Test9));
            Assert.AreEqual(4, Binary.BinaryArrayToNumber(Test10));
        }
        [Test]
        public void Binary_BinaryArrayToNumber_RandomTest()
        {
            int[] arr = new int[4];
            for (int i = 0; i < arr.Length; i++) { arr[i] = new Random().Next(0, 2); System.Threading.Thread.Sleep(5); }
            Assert.AreEqual(binaryArrayToNumberSolution(arr), Binary.BinaryArrayToNumber(arr));
        }
    }
}
