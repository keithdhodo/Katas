using KeithKatas.July2017;
using NUnit.Framework;
using System;
using System.Text;

namespace KeithKatas.Tests.July2017
{
    [TestFixture]
    public class DecimalPlacesTests
    {
        [Test]
        public void DecimalPlacesSimpleTest_01()
        {
            Assert.AreEqual(10.12, DecimalPlaces.TwoDecimalPlaces(10.1289767789));
        }

        [Test]
        public void DecimalPlacesSimpleTest_Negative_02()
        {
            Assert.AreEqual(-7488.83, DecimalPlaces.TwoDecimalPlaces(-7488.83485834983));
        }

        [Test]
        public void DecimalPlaces_Test_Random_03([Random(-2837823.73748453445, 2837823.73748453445, 98)]double number)
        {
            Assert.AreEqual(this.TwoDecimalPlaces(number), DecimalPlaces.TwoDecimalPlaces(number));
        }

        private double TwoDecimalPlaces(double number)
        {
            var input = (number.ToString()).ToCharArray();
            var shortenedNumber = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '.')
                {
                    for (int a = 0; a < i + 3; a++)
                    {
                        shortenedNumber.Append(input[a]);
                    }
                    break;
                }
            }
            return Double.Parse(shortenedNumber.ToString());
        }
    }
}
