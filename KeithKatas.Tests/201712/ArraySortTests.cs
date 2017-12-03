using Kata.December2017;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class ArraySortTests
    {
        [Test]
        public void ArraySort_IsSortedAndHow_BasicTests()
        {
            Assert.AreEqual("yes, ascending", ArraySort.IsSortedAndHow(new[] { 1, 2 }));
            Assert.AreEqual("yes, descending", ArraySort.IsSortedAndHow(new[] { 15, 7, 3, -8 }));
            Assert.AreEqual("no", ArraySort.IsSortedAndHow(new[] { 4, 2, 30 }));
        }

        [Test]
        public void ArraySort_IsSortedAndHow_RandomTests()
        {
            Random rand = new Random();

            Func<int, int[]> randomArray = delegate (int size)
            {
                var array = Enumerable.Range(0, size).Select(a => rand.Next(-10000, 20000)).ToArray();

                var x = rand.Next(0, 5);
                if (x == 1 || x == 2)
                {
                    array = array.OrderBy(a => a).ToArray();
                }
                else
                {
                    if (x == 3 || x == 4)
                    {
                        array = array.OrderBy(a => -a).ToArray();
                    }
                }
                return array;
            };

            Func<int[], string> myIsSortedAndHow = delegate (int[] array)
            {
                if (array.OrderBy(a => a).SequenceEqual(array)) return "yes, ascending";
                if (array.OrderByDescending(a => a).SequenceEqual(array)) return "yes, descending";
                return "no";
            };

            var testArray = randomArray(7);
            var expected = myIsSortedAndHow(testArray);
            var actual = ArraySort.IsSortedAndHow(testArray);
            Assert.AreEqual(expected, actual);

            testArray = randomArray(57);
            expected = myIsSortedAndHow(testArray);
            actual = ArraySort.IsSortedAndHow(testArray);
            Assert.AreEqual(expected, actual);

            testArray = randomArray(184);
            expected = myIsSortedAndHow(testArray);
            actual = ArraySort.IsSortedAndHow(testArray);
            Assert.AreEqual(expected, actual);

            testArray = randomArray(7392);
            expected = myIsSortedAndHow(testArray);
            actual = ArraySort.IsSortedAndHow(testArray);
            Assert.AreEqual(expected, actual);

            testArray = randomArray(12345);
            expected = myIsSortedAndHow(testArray);
            actual = ArraySort.IsSortedAndHow(testArray);
            Assert.AreEqual(expected, actual);
        }
    }
}
