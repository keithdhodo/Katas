using Kata.November2017;
using NUnit.Framework;
using System;

namespace KeithKatas.TestsNovember2017
{
    [TestFixture]
    public class ItemCounterTests
    {
        [Test]
        public void GivenACallToConstructor_WhenPassedNullArgument_ThrowsArgumentNullException()
        {
            // ACT
            TestDelegate testDelegate = delegate { new ItemCounter<string>(null); };

            // ASSERT
            Assert.Throws<ArgumentNullException>(testDelegate);
        }

        [Test]
        public void DistinctItems_AfterConstructionWithEmptyArray_IsZero()
        {
            // ARRANGE
            var items = new string[] { };
            var counter = new ItemCounter<string>(items);

            // ACT
            var actualCount = counter.DistinctItems;

            // ASSERT
            Assert.AreEqual(0, actualCount);
        }

        [Test]
        public void DistinctItems_AfterConstructionWithTwoSameItemsArray_IsOne()
        {
            // ARRANGE
            var items = new[] { "Apple", "Apple" };
            var counter = new ItemCounter<string>(items);

            // ACT
            var actualCount = counter.DistinctItems;

            // ASSERT
            Assert.AreEqual(1, actualCount);
        }

        [Test]
        public void DistinctItems_AfterConstructionWithTwoDifferentItemsArray_IsTwo()
        {
            // ARRANGE
            var items = new[] { "Apple", "Orange" };
            var counter = new ItemCounter<string>(items);

            // ACT
            var actualCount = counter.DistinctItems;

            // ASSERT
            Assert.AreEqual(2, actualCount);
        }


        [Test]
        public void DistinctItems_AfterConstructionWithThreeItemsTwoSameAndOneDifferen_IsTwo()
        {
            // ARRANGE
            var items = new[] { "Apple", "Orange", "Apple", };
            var counter = new ItemCounter<string>(items);

            // ACT
            var actualCount = counter.DistinctItems;

            // ASSERT
            Assert.AreEqual(2, actualCount);
        }

        [Test]
        public void GetCount_AfterConstructionWithTwoSameItemsArray_IsTwo()
        {
            // ARRANGE
            var item1 = "Apple";
            var item2 = item1;
            var items = new[] { item1, item2 };
            var counter = new ItemCounter<string>(items);

            // ACT
            var actualCount = counter.GetCount(item1);

            // ASSERT
            Assert.AreEqual(2, actualCount);
        }

        [Test]
        public void GetCount_AfterConstructionWithTwoDifferentItemsArray_IsOne()
        {
            // ARRANGE
            var item1 = "Apple";
            var item2 = "Banana";
            var items = new[] { item1, item2 };
            var counter = new ItemCounter<string>(items);

            // ACT
            var actualCount = counter.GetCount(item1);

            // ASSERT
            Assert.AreEqual(1, actualCount);
        }

        [Test]
        public void GetCount_WhenSpecifyingNonExistingItem_ThrowsException()
        {
            // ARRANGE
            var items = new[] { "Apple", "Apple" };
            var counter = new ItemCounter<string>(items);

            // ACT
            TestDelegate testDelegate = delegate { counter.GetCount("Pear"); };

            // ASSERT
            Assert.Throws<InvalidOperationException>(testDelegate);
        }

        [Test]
        public void GetCount_WhenSpecifyingNullItem_ThrowsException()
        {
            // ARRANGE
            var items = new[] { "Apple", "Apple" };
            var counter = new ItemCounter<string>(items);

            // ACT
            TestDelegate testDelegate = delegate { counter.GetCount(null); };

            // ASSERT
            Assert.Throws<ArgumentNullException>(testDelegate);
        }

        [Test]
        public void HasItem_WhenItemExists_ReturnsTrue()
        {
            // ARRANGE
            var item = "Apple";
            var items = new[] { item };
            var counter = new ItemCounter<string>(items);

            // ACT
            var actual = counter.HasItem(item);

            // ASSERT
            Assert.IsTrue(actual);
        }

        [Test]
        public void HasItem_WhenItemDoesNotExist_ReturnsFalse()
        {
            // ARRANGE
            var item1 = "Apple";
            var item2 = "Pear";
            var items = new[] { item1 };
            var counter = new ItemCounter<string>(items);

            // ACT
            var actual = counter.HasItem(item2);

            // ASSERT
            Assert.IsFalse(actual);
        }
    }
}
