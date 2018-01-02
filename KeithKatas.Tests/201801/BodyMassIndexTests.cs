using KeithKatas.January2018;
using NUnit.Framework;
using System;

namespace KeithKatas.Tests.January2018
{
    [TestFixture]
    public class BodyMassIndexTests
    {
        private static Random rnd = new Random();

        private static string Solution(double w, double h)
        {
            double r = w / (h * h);
            return (r > 30) ? "Obese" : (r > 25) ? "Overweight" : (r > 18.5) ? "Normal" : "Underweight";
        }

        [Test, Description("Fixed Tests")]
        public void BodyMassIndex_Bmi_SampleTest()
        {
            Assert.AreEqual("Normal", BodyMassIndex.Bmi(80, 1.80));
            Assert.AreEqual("Normal", BodyMassIndex.Bmi(80, 1.80));
            Assert.AreEqual("Overweight", BodyMassIndex.Bmi(90, 1.80));
            Assert.AreEqual("Obese", BodyMassIndex.Bmi(110, 1.80));
        }

        [Test, Description("Random Tests")]
        public void BodyMassIndex_Bmi_RandomTest()
        {
            for (int i = 0; i < 100; ++i)
            {
                double weight = rnd.NextDouble() * 250 + 50;
                double height = rnd.NextDouble() * 2.5 + 0.5;
                string expected = Solution(weight, height);
                string actual = BodyMassIndex.Bmi(weight, height);
                Assert.AreEqual(expected, actual);
            }
        }
    }
}
