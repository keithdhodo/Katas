using KeithKatas.August2016;
using NUnit.Framework;
using System;
using System.Linq;

namespace Sandbox.August2016
{
    [TestFixture]
    public class LogicalCalculatorTests
    {
        [Test]
        public void LogicalCalculatorTest1()
        {
            Assert.AreEqual(false, LogicalCalculator.LogicalCalc(new bool[] { true, true, true, false }, "AND"));
            Assert.AreEqual(true, LogicalCalculator.LogicalCalc(new bool[] { true, true, true, false }, "OR"));
            Assert.AreEqual(true, LogicalCalculator.LogicalCalc(new bool[] { true, true, true, false }, "XOR"));
            Assert.AreEqual(false, LogicalCalculator.LogicalCalc(new bool[] { true, true, false, false }, "AND"));
            Assert.AreEqual(true, LogicalCalculator.LogicalCalc(new bool[] { true, true, false, false }, "OR"));
            Assert.AreEqual(false, LogicalCalculator.LogicalCalc(new bool[] { true, true, false, false }, "XOR"));
            Assert.AreEqual(false, LogicalCalculator.LogicalCalc(new bool[] { true, false, false, false }, "AND"));
            Assert.AreEqual(true, LogicalCalculator.LogicalCalc(new bool[] { true, false, false, false }, "OR"));
            Assert.AreEqual(true, LogicalCalculator.LogicalCalc(new bool[] { true, false, false, false }, "XOR"));
            Assert.AreEqual(true, LogicalCalculator.LogicalCalc(new bool[] { true, true }, "AND"));
            Assert.AreEqual(true, LogicalCalculator.LogicalCalc(new bool[] { true, true }, "OR"));
            Assert.AreEqual(false, LogicalCalculator.LogicalCalc(new bool[] { true, true }, "XOR"));
            Assert.AreEqual(false, LogicalCalculator.LogicalCalc(new bool[] { false, false }, "AND"));
            Assert.AreEqual(false, LogicalCalculator.LogicalCalc(new bool[] { false, false }, "OR"));
            Assert.AreEqual(false, LogicalCalculator.LogicalCalc(new bool[] { false, false }, "XOR"));
            Assert.AreEqual(false, LogicalCalculator.LogicalCalc(new bool[] { false }, "AND"));
            Assert.AreEqual(false, LogicalCalculator.LogicalCalc(new bool[] { false }, "OR"));
            Assert.AreEqual(false, LogicalCalculator.LogicalCalc(new bool[] { false }, "XOR"));
            Assert.AreEqual(true, LogicalCalculator.LogicalCalc(new bool[] { true }, "AND"));
            Assert.AreEqual(true, LogicalCalculator.LogicalCalc(new bool[] { true }, "OR"));
            Assert.AreEqual(true, LogicalCalculator.LogicalCalc(new bool[] { true }, "XOR"));
        }

        [Test]
        public void LogicalCalculatorTestRandomTests()
        {
            var rand = new Random();
            var ops = new[] { "AND", "OR", "XOR" };

            Func<bool[], string, bool> myLogicalCalc = delegate (bool[] arr, string op)
            {
                return arr.Aggregate((a, b) => op == "AND" ? a && b : op == "OR" ? a || b : a != b);
            };

            for (int i = 0; i < 40; i++)
            {
                var arr = Enumerable.Range(3, 20).Select(a => rand.Next(0, 2) == 0 ? true : false).ToArray();
                foreach (var op in ops)
                {
                    Console.WriteLine("Testing for { " + string.Join(", ", arr) + " } with \"" + op + "\"...");
                    Assert.AreEqual(myLogicalCalc(arr, op), LogicalCalculator.LogicalCalc(arr, op), "It should work for random inputs too");
                }
            }
        }
    }
}
