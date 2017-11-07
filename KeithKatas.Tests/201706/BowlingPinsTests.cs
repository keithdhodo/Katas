using KeithKatas.June2017;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KataTests.June2017
{
    [TestFixture]
    public class BowlingPinsTests
    {
        [Test]
        public void BowlingPinsTestsExampleTests()
        {
            BowlingPins bowling = new BowlingPins();
            int[] testArray = new int[] { 1, 2, 3 };
            Assert.AreEqual("I I I I\n I I I \n       \n       ", bowling.Bowl(testArray));

            testArray = new int[] { 3, 5, 9 };
            Assert.AreEqual("I I   I\n I   I \n  I    \n   I   ", bowling.Bowl(testArray));
        }

        [Test]
        public void BowlingPinsTestsBasicTests()
        {
            BowlingPins bowling = new BowlingPins();
            int[] testArray = null;
            var ret = bowling.Bowl(testArray);
            Assert.AreEqual("I I I I\n I I I \n  I I  \n   I   ", ret);

            testArray = new int[] { };
            Assert.AreEqual("I I I I\n I I I \n  I I  \n   I   ", bowling.Bowl(testArray));
        }

        [Test]
        public void RandomTests()
        {
            BowlingPins bowling = new BowlingPins();
            for (int i = 0; i < 50; i++)
            {
                int[] rnd = GetRandomArray();
                Assert.AreEqual(Countdown(rnd), bowling.Bowl(rnd));
            }
        }

        public int[] GetRandomArray()
        {
            List<int> arrList = new List<int>();
            int times = new Random().Next(0, 11);
            for (int i = 0; i < times; i++)
            {
                int rnd = new Random().Next(1, 11);
                if (arrList.IndexOf(rnd) == -1)
                {
                    arrList.Add(rnd);
                }
            }
            return arrList.ToArray();
        }

        public string Countdown(int[] arr)
        {
            string pins = "";
            int rowLength = 4;
            int maxLength = 4;
            int[] init = new int[] { 7, 8, 9, 10, 4, 5, 6, 2, 3, 1 };
            for (int i = 0; i < init.Length;)
            {
                pins += new String(' ', maxLength - rowLength);
                for (var r = 0; r < rowLength; r++)
                {
                    if (!arr.Contains(init[i]))
                    {
                        pins += "I";
                    }
                    else
                    {
                        pins += " ";
                    }
                    pins += r + 1 < rowLength ? " " : "";
                    i++;
                }
                pins += new String(' ', maxLength - rowLength);
                pins += rowLength > 1 ? "\n" : "";
                rowLength--;
            }
            return pins;
        }
    }
}
