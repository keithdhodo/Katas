using Kata.December2017;
using NUnit.Framework;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class AlternateSortTests
    {
        [Test]
        public void AlternateSort_SortByZ_BasicTest1()
        {
            Assert.AreEqual(new[] {"Rabbit", "Deer", "Chicken", "Cow" }, AlternateSort.SortByZ(new[] { "Cow", "Chicken", "Deer", "Rabbit" }, 3));
        }

        [Test]
        public void AlternateSort_SortByZ_BasicTest2()
        {
            Assert.AreEqual(new[] { "Believe", "Rain", "Sunshine", "Justice" }, AlternateSort.SortByZ(new[] { "Rain", "Sunshine", "Believe", "Justice" }, 4));
        }

        [Test]
        public void AlternateSort_SortByZ_BasicTest3()
        {
            Assert.AreEqual(new[] { "ca", "ec", "af" }, AlternateSort.SortByZ(new[] { "af", "ca", "ec"}, 2));
        }

        [Test]
        public void AlternateSort_SortByZ_BasicTest4()
        {
            Assert.AreEqual(new[] {
                "ab56b4d92b40713acc5af89985d4b786",
                 "67b02d0abc302005829625e99abeb0c0",
                 "0cc175b9c0f1b6a831c399e269772661",
                 "7010d207ba8188295fb26e35c8afb9f8",
                 "900150983cd24fb0d6963f7d28e17f72",
                 "4dd77ecaf88620f5da8967bbd91d9506",
                 "5dc2d953bcb9d667c79aaa5e1f9e41c5",
                 "6d0007e52f7afb7d5a0650b0ffb8a4d1",
                 "7ddf32e17a6ac5ce04a8ecbf782ca509",
                 "6a204bd89f3c8348afd5c77c717a097a",
                 "7ac66c0f148de9519b8bd264312c4d64",
                 "4d80a450f40da2bc13215d7877c7d8b4",
                 "fc8fca0fcdde437fa57fd71cee333926" }, 
                AlternateSort.SortByZ(new[] {
                "6d0007e52f7afb7d5a0650b0ffb8a4d1",
                "0cc175b9c0f1b6a831c399e269772661",
                 "900150983cd24fb0d6963f7d28e17f72",
                 "ab56b4d92b40713acc5af89985d4b786",
                 "7ac66c0f148de9519b8bd264312c4d64",
                 "4dd77ecaf88620f5da8967bbd91d9506",
                 "fc8fca0fcdde437fa57fd71cee333926",
                 "7010d207ba8188295fb26e35c8afb9f8",
                 "6a204bd89f3c8348afd5c77c717a097a",
                 "5dc2d953bcb9d667c79aaa5e1f9e41c5",
                 "67b02d0abc302005829625e99abeb0c0",
                 "7ddf32e17a6ac5ce04a8ecbf782ca509",
                 "4d80a450f40da2bc13215d7877c7d8b4" }, 
                 12));
        }

        [Test]
        public void AlternateSort_SortByZ_BasicTest5()
        {
            Assert.AreEqual(new[] {
                "bananas",
                "strawberries",
                "watermelons",
                "apples",
                "plums",
                "oranges",
                "grapes",
                "cherries",
                "pears" }, 
                AlternateSort.SortByZ(new[] {
                "grapes",
                "bananas",
                "cherries",
                "plums",
                "oranges",
                "strawberries",
                "watermelons",
                "pears",
                "apples" },
                4));
        }
    }
}
