﻿using Kata.November2017;
using NUnit.Framework;
using System;
using System.Linq;

namespace KeithKatas.Tests.November2017
{
    public class LargestFiveDigitSequenceTests
    {
        [Test]
        public void LargestFiveDigitSequence_GetNumber_BasicTest()
        {
            String str = "7316717653133062491922511967442657474235534919493496983520368542506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753123457977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257540920752963450";

            Assert.AreEqual(99890, LargestFiveDigitSequence.GetNumber(str));
        }

        [Test]
        public void LargestFiveDigitSequence_GetNumber_OffByOneTest()
        {
            Assert.AreEqual(98765, LargestFiveDigitSequence.GetNumber("1234567898765"));
        }

        [Test]
        public void LargestFiveDigitSequence_GetNumber_RandomTest()
        {
            for (int i = 0; i < 100; ++i)
            {
                string str = randomSequence(rnd.Next(5, 1000));
                Assert.AreEqual(Solution(str), LargestFiveDigitSequence.GetNumber(str), "Failed with " + str);
            }
        }

        private static Random rnd = new Random();

        private static int Solution(string str)
        {
            int max = 0;
            for (int i = 0; i < str.Length - 4; ++i)
            {
                int num = Int32.Parse(str.Substring(i, 5));
                max = num > max ? num : max;
            }
            return max;
        }

        private static string randomSequence(int len) =>
          String.Concat(new char[rnd.Next(5, 1000)].Select(_ => (char)rnd.Next(48, 58)));
    }
}
