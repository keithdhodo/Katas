using KeithKatas.October2017;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KeithKatas.Tests.October2017
{
    [TestFixture]
    public class PinTests
    {
        [Test, Description("ValidatePin should return false for pins with length other than 4 or 6")]
        public void Pin_ValidatePin_TestLength()
        {
            Assert.AreEqual(false, Pin.ValidatePin("1"), "Wrong output for \"1\"");
            Assert.AreEqual(false, Pin.ValidatePin("12"), "Wrong output for \"12\"");
            Assert.AreEqual(false, Pin.ValidatePin("123"), "Wrong output for \"123\"");
            Assert.AreEqual(false, Pin.ValidatePin("12345"), "Wrong output for \"12345\"");
            Assert.AreEqual(false, Pin.ValidatePin("1234567"), "Wrong output for \"1234567\"");
            Assert.AreEqual(false, Pin.ValidatePin("-1234"), "Wrong output for \"-1234\"");
            Assert.AreEqual(false, Pin.ValidatePin("1.234"), "Wrong output for \"1.234\"");
            Assert.AreEqual(false, Pin.ValidatePin("00000000"), "Wrong output for \"00000000\"");
            Assert.AreEqual(false, Pin.ValidatePin("j84367"), "Wrong output for \"j84367\"");
        }

        [Test, Description("ValidatePin should return false for pins which contain characters other than digits")]
        public void Pin_ValidatePin_NonDigitTest()
        {
            Assert.AreEqual(false, Pin.ValidatePin("a234"), "Wrong output for \"a234\"");
            Assert.AreEqual(false, Pin.ValidatePin(".234"), "Wrong output for \".234\"");
        }

        [Test, Description("ValidatePin should return true for valid pins")]
        public void Pin_ValidatePin_ValidTest()
        {
            Assert.AreEqual(true, Pin.ValidatePin("1234"), "Wrong output for \"1234\"");
            Assert.AreEqual(true, Pin.ValidatePin("0000"), "Wrong output for \"0000\"");
            Assert.AreEqual(true, Pin.ValidatePin("1111"), "Wrong output for \"1111\"");
            Assert.AreEqual(true, Pin.ValidatePin("123456"), "Wrong output for \"123456\"");
            Assert.AreEqual(true, Pin.ValidatePin("098765"), "Wrong output for \"098765\"");
            Assert.AreEqual(true, Pin.ValidatePin("000000"), "Wrong output for \"000000\"");
            Assert.AreEqual(true, Pin.ValidatePin("090909"), "Wrong output for \"090909\"");
        }

        [Test, Description("ValidatePin calls for 100 randomly generated pins")]
        public void Pin_ValidatePin_RandomTests()
        {
            Random rnd = new Random();
            string digits = "0123456789";
            bool solution(string pin) => (pin.Length == 4 || pin.Length == 6) && pin.All(Char.IsDigit);

            const int Tests = 100;

            for (int i = 0; i < Tests; ++i)
            {
                List<char> validPin = new char[rnd.Next(2, 4) * 2].Select(_ => digits[rnd.Next(0, digits.Length)]).ToList();
                if (rnd.Next(0, 2) == 0) { validPin[rnd.Next(0, validPin.Count)] = (char)rnd.Next(32, 127); }
                string pin = String.Concat(validPin);

                bool expected = solution(pin);

                Assert.AreEqual(expected, Pin.ValidatePin(pin), $"{pin} should be {(expected ? "valid" : "invalid")}");
            }
        }
    }
}
