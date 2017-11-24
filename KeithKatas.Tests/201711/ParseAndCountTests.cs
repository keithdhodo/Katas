using Kata.November2017;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace KeithKatas.Tests.November2017
{
    [TestFixture]
    public class ParseAndCountTests
    {
        [Test]
        public void ParseAndCount_PaC_Checkex()
        {
            Assert.AreEqual(2281337, ParseAndCount.PaC("[wqettr1-2qwe+Enter number: 2281337"));

            Assert.AreEqual(1561889, ParseAndCount.PaC("wqrrrq]q-++ Enter answer: 6334 +1555555"));

            Assert.AreEqual(1549221, ParseAndCount.PaC("wqr+rq-+ Enter answer: 1555555 - 6334"));
        }

        public Dictionary<string, int> randomTests = new Dictionary<string, int>();

        [Test]

        public void ParseAndCount_PaC_RandomTests()
        {
            Dictionary<string, int> tests = new Dictionary<string, int>();
            for (int i = 0; i < 1000; i++)
            {
                try
                {
                    int ans = new Random().Next(100, 1000000);
                    tests.Add("Enter number: " + ans.ToString(), ans);
                    int n1 = new Random().Next(0, 1000000);
                    int n2 = new Random(DateTime.Now.Millisecond).Next(0, 1000000);
                    if (new Random().Next(0, 1000) < 500)
                        tests.Add("Enter answer: " + n1.ToString() + "+" + n2.ToString(), n1 + n2);
                    else
                        tests.Add("Enter answer: " + n1.ToString() + "-" + n2.ToString(), n1 - n2);
                }
                catch (Exception) { }
            }

            randomTests = tests;
            Console.WriteLine("Random Tests loaded!");
            ParseAndCount source = new ParseAndCount();
            int testn = 0;
            int output = 0;
            foreach (var test in randomTests)
            {
                Console.WriteLine("Input: " + test.Key + " | Output: " + test.Value);
                output = ParseAndCount.PaC(test.Key);
                Console.WriteLine("Solution output: " + output.ToString());
                Assert.AreEqual(test.Value, output);
                Console.WriteLine("Test #" + testn.ToString() + " completed.");
                testn++;
            }
            Console.WriteLine("Good Job!");
        }
    }
}
