using KeithKatas.October2017;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace KeithKatas.Tests.October2017
{
    [TestClass]
    public class ShortestWordTests
    {
        [TestMethod]
        public void ShortestWord_BasicTest1()
        {
            Assert.AreEqual(3, ShortestWord.FindShort("bitcoin take over the world maybe who knows perhaps"));
        }

        [TestMethod]
        public void ShortestWord_BasicTest2()
        {
            Assert.AreEqual(3, ShortestWord.FindShort("turns out random test cases are easier than writing out basic ones"));
        }

        [TestMethod]
        public void ShortestWord_BasicTest3()
        {
            Assert.AreEqual(3, ShortestWord.FindShort("lets talk about javascript the best language"));
        }

        [TestMethod]
        public void ShortestWord_BasicTest4()
        {
            Assert.AreEqual(1, ShortestWord.FindShort("i want to travel the world writing code one day"));
        }

        [TestMethod]
        public void ShortestWord_BasicTest5()
        {
            Assert.AreEqual(2, ShortestWord.FindShort("Lets all go on holiday somewhere very cold"));
        }

        [TestMethod]
        public void ShortestWord_RandomTests()
        {
            var rand = new Random();
            var names = new[] { "Bitcoin", "LiteCoin", "Ripple", "Dash", "Lisk", "DarkCoin", "Monero", "Ethereum", "Classic", "Mine", "ProofOfWork", "ProofOfStake", "21inc", "Steem", "Dogecoin", "Waves", "Factom", "MadeSafeCoin", "BTC" };

            for (var i = 0; i < 40; i++)
            {
                var s = string.Join(" ", Enumerable.Range(0, rand.Next(1, 20)).Select(a => names[rand.Next(0, names.Length)]));

                var expected = s.Split(' ').Select(w => w.Length).Min();

                Assert.AreEqual(expected, ShortestWord.FindShort(s), "It should work for random inputs too");
            }
        }
    }
}
