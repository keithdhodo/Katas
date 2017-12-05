using Kata.December2017;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class FullNameTests
    {
        private static Random rnd = new Random();

        private static string[] first = new string[] { "", "Clint", "Giake", "mYjin", "Stef", "Jake", "", "Keith", "Joshua", "Amber", "Isaac", "Paige", "Ivan", "" };
        private static string[] last = new string[] { "", "East", "North", "West", "South", "", "Helm", "Harwell", "Brazil", "Schiller", "Meyer", "Kozlov", "" };

        private static IEnumerable<TestCaseData> EdgeTestCases
        {
            get
            {
                yield return new TestCaseData("Clint", "").Returns("Clint").SetDescription("No Last Name");
                yield return new TestCaseData("", "Eastwood").Returns("Eastwood").SetDescription("No First Name");
                yield return new TestCaseData("", "").Returns("").SetDescription("No First or Last Name");
            }
        }

        private static IEnumerable<TestCaseData> RandomTestCases
        {
            get
            {
                const int Tests = 1000;

                for (int i = 0; i < Tests; ++i)
                {
                    string firstName = first[rnd.Next(0, first.Length)];
                    string lastName = last[rnd.Next(0, last.Length)];

                    string expected = (firstName + " " + lastName).Trim();

                    yield return new TestCaseData(firstName, lastName).Returns(expected).SetDescription(String.Format("Random Test #{0}, Expected: {1}", i + 1, expected));
                }
            }
        }

        [Test, Description("Sample Test")]
        public void FullName_GetFullName_SampleTest() => Assert.AreEqual("Clint Eastwood", new FullName("Clint", "Eastwood").GetFullName);

        [Test, TestCaseSource("EdgeTestCases")]
        public string FullName_GetFullName_EdgeTests(string firstName, string lastName) => new FullName(firstName, lastName).GetFullName;

        [Test, TestCaseSource("RandomTestCases")]
        public string FullName_GetFullName_RandomTests(string firstName, string lastName) => new FullName(firstName, lastName).GetFullName;
    }
}
