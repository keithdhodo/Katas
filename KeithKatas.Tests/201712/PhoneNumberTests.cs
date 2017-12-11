﻿using Kata.December2017;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class PhoneNumberTests
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, ExpectedResult = "(123) 456-7890")]
        [TestCase(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, ExpectedResult = "(111) 111-1111")]
        public static string PhoneNumber_PhoneNumber_FixedTest(int[] numbers)
        {
            return PhoneNumber.CreatePhoneNumber(numbers);
        }

        private static string Solution(int[] numbers)
        {
            string result = "";
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0) result += "(";
                result += numbers[i];
                if (i == 2) result += ") ";
                if (i == 5) result += "-";
            }
            return result;
        }

        [Test]
        public static void PhoneNumber_PhoneNumber_RandomTest([Random(0, 9, 50)]int num)
        {
            List<int> list = new List<int>();
            Random r = new Random();
            for (int i = 0; i < 9; i++) list.Add(r.Next(10));
            list.Add(num);
            int[] numbers = list.ToArray();
            Assert.AreEqual(Solution(numbers), PhoneNumber.CreatePhoneNumber(numbers));
        }
    }
}
