using Kata.November2017;
using NUnit.Framework;
using System;
using System.Linq;


namespace KeithKatas.Tests.November2017
{
    [TestFixture]
    public class MathematicsTests
    {
        [Test]
        public void Mathematics_SumTwoSmallestNumbers_SampleTest()
        {
            int[] numbers = { 5, 8, 12, 19, 22 };
            Assert.AreEqual(13, Mathematics.SumTwoSmallestNumbers(numbers));
        }

        [Test]
        public void Mathematics_SumTwoSmallestNumbers_Test2()
        {
            int[] numbers = { 15, 28, 4, 2, 43 };
            Assert.AreEqual(6, Mathematics.SumTwoSmallestNumbers(numbers));
        }

        [Test]
        public void Mathematics_SumTwoSmallestNumbers_Test3()
        {
            int[] numbers = { 3, 87, 45, 12, 7 };
            Assert.AreEqual(10, Mathematics.SumTwoSmallestNumbers(numbers));
        }

        [Test]
        public void Mathematics_SumTwoSmallestNumbers_Test4()
        {
            int[] numbers = { 23, 71, 33, 82, 1 };
            Assert.AreEqual(24, Mathematics.SumTwoSmallestNumbers(numbers));
        }

        [Test]
        public void Mathematics_SumTwoSmallestNumbers_Test5()
        {
            int[] numbers = { 52, 76, 14, 12, 4 };
            Assert.AreEqual(16, Mathematics.SumTwoSmallestNumbers(numbers));
        }

        private static Random rnd = new Random();

        private static int solution(int[] numbers) => numbers.OrderBy(i => i).Take(2).Sum();

        [Test]
        public void Mathematics_SumTwoSmallestNumbers_RandomTests()
        {
            var numbers = new int[rnd.Next(0, 100)];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next();

                int expected = solution(numbers);
                int actual = Mathematics.SumTwoSmallestNumbers(numbers);
                Assert.AreEqual(expected, actual);
            }
        }

        [Test]
        public void Mathematics_Factorial_Of0ShouldBe1()
        {
            Assert.AreEqual(1, Mathematics.Factorial(0));
        }

        [Test]
        public void Mathematics_Factorial_Of1ShouldBe1()
        {
            Assert.AreEqual(1, Mathematics.Factorial(1));
        }

        [Test]
        public void Mathematics_Factorial_Of2ShouldBe2()
        {
            Assert.AreEqual(2, Mathematics.Factorial(2));
        }

        [Test]
        public void Mathematics_Factorial_Of3ShouldBe6()
        {
            Assert.AreEqual(6, Mathematics.Factorial(3));
        }

        [Test]
        public void Mathematics_Factorial_AllFactorialsShouldBeCorrect()
        {
            for (var i = 0; i < 12; i++)
            {
                Assert.AreEqual(Factorial(i), Mathematics.Factorial(i));
            }
        }

        [Test]
        public void Mathematics_Factorial_FactorialForNegativeInputShouldThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Mathematics.Factorial(-1));
        }

        [Test]
        public void Mathematics_Factorial_FactorialFor13ShouldThrow()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Mathematics.Factorial(13));
        }

        private int Factorial(int x)
        {
            if (x < 0 || x > 12) throw new ArgumentOutOfRangeException();
            return x == 0 ? 1 : x * Factorial(x - 1);
        }
    }
}
