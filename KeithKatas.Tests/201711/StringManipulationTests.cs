using Kata.November2017;
using NUnit.Framework;
using System;

namespace KeithKatas.Tests.November2017
{
    [TestFixture]
    public class StringManipulationTests
    {
        [Test]
        public void StringManipulation_NoSpace_BasicTests()
        {
            Assert.AreEqual("8j8mBliB8gimjB8B8jlB", StringManipulation.NoSpace("8 j 8   mBliB8g  imjB8B8  jl  B"));
            Assert.AreEqual("88Bifk8hB8BB8BBBB888chl8BhBfd", StringManipulation.NoSpace("8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd"));
            Assert.AreEqual("8aaaaaddddr", StringManipulation.NoSpace("8aaaaa dddd r     "));
            Assert.AreEqual("jfBmgklf8hg88lbe8", StringManipulation.NoSpace("jfBm  gk lf8hg  88lbe8 "));
            Assert.AreEqual("8jaam", StringManipulation.NoSpace("8j aam"));
        }

        [Test]
        public void StringManipulation_NoSpace_RandomTests()
        {
            Random rand = new Random();
            string[] names = new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "P", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", " ", " ", " ", " ", " ", " " };
            for (int i = 0; i < 100; i++)
            {
                string x = "";
                int len = rand.Next(1, 30);
                for (int j = 0; j < len; j++)
                {
                    x += names[rand.Next(0, names.Length - 1)];
                }

                var expected = x.Replace(" ", string.Empty);

                Assert.AreEqual(expected, StringManipulation.NoSpace(x));
            }
        }
    }
}
