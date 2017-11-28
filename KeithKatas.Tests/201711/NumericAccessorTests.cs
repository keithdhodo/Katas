using Kata.November2017;
using NUnit.Framework;
using System;

namespace KeithKatas.Tests.November2017
{
    [TestFixture]
    public class NumericAccessorTests
    {
        [Test]
        public void NumericAccessor_ValidSetterOnlyCheck1()
        {
            //sut --> subject under test
            var sut = new NumericAccessor();
            sut.Number = 24;
            Assert.AreEqual(24, sut.GetUnalteredNumber());
        }

        [Test]
        public void NumericAccessor_ValidSetterOnlyCheck2()
        {
            var sut = new NumericAccessor();
            sut.Number = 2;
            Assert.AreEqual(2, sut.GetUnalteredNumber());
        }

        [Test]
        public void NumericAccessor_ValidSetterOnlyCheck3()
        {
            var sut = new NumericAccessor();
            sut.Number = 0;
            Assert.AreEqual(0, sut.GetUnalteredNumber());
        }

        [Test]
        public void NumericAccessor_OddValuedSetterCheck1()
        {
            var sut = new NumericAccessor();
            try
            {
                sut.Number = 1;
            }
            catch (ArgumentException e)
            {
                Assert.Pass("Correct exception type thrown");
            }
            Assert.Fail("Expected exception on odd value input");
        }

        [Test]
        public void NumericAccessor_OddValuedSetterCheck2()
        {
            var sut = new NumericAccessor();
            try
            {
                sut.Number = 9;
            }
            catch (ArgumentException e)
            {
                Assert.Pass("Correct exception type thrown");
            }
            Assert.Fail("Expected exception on odd value input");
        }

        [Test]
        public void NumericAccessor_OddValuedSetterCheck3()
        {
            var sut = new NumericAccessor();
            try
            {
                sut.Number = 7;
            }
            catch (ArgumentException e)
            {
                Assert.Pass("Correct exception type thrown");
            }
            Assert.Fail("Expected exception on odd value input");
        }

        [Test]
        public void NumericAccessor_OddValuedSetterCheck4()
        {
            var sut = new NumericAccessor();
            try
            {
                sut.Number = -3;
            }
            catch (ArgumentException e)
            {
                Assert.Pass("Correct exception type thrown");
            }
            Assert.Fail("Expected exception on odd value input");
        }

        [Test]
        public void NumericAccessor_GetterAndSetterCheck1()
        {
            //sut --> subject under test
            var sut = new NumericAccessor();
            sut.Number = 6;
            Assert.AreEqual(3, sut.Number);
        }

        [Test]
        public void NumericAccessor_GetterAndSetterCheck2()
        {
            //sut --> subject under test
            var sut = new NumericAccessor();
            sut.Number = 16;
            Assert.AreEqual(8, sut.Number);
        }

        [Test]
        public void NumericAccessor_GetterAndSetterCheck3()
        {
            //sut --> subject under test
            var sut = new NumericAccessor();
            sut.Number = -6;
            Assert.AreEqual(-3, sut.Number);
        }

        [Test]
        public void NumericAccessor_GetterAndSetterCheck4()
        {
            //sut --> subject under test
            var sut = new NumericAccessor();
            sut.Number = 100;
            Assert.AreEqual(50, sut.Number);
        }

        [Test]
        public void NumericAccessor_RandomValueCheck()
        {
            var sut = new NumericAccessor();
            Random rng = new Random();
            for (var i = 0; i < 100; i++)
            {
                var a = rng.Next(-2000, 2000);
                if (a % 2 == 0)
                {
                    sut.Number = a;
                    Assert.AreEqual(a / 2, sut.Number);
                    Assert.AreEqual(a, sut.GetUnalteredNumber());
                }
                else
                {
                    try
                    {
                        sut.Number = a;
                    }
                    catch (ArgumentException e)
                    {
                        continue;
                    }
                    Assert.Fail("Expected exception on odd value input");
                }
            }
        }
    }
}
