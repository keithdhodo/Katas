using NUnit.Framework;
using CustomExtensions;
using System;

namespace KeithKatas.Tests.January2018
{
    [TestFixture]
    public class AlternatingCaseTests
    {
        [Test]
        public void AlternatingCase_ToAlternatingCase_Examples()
        {
            Assert.AreEqual("HELLO WORLD", "hello world".ToAlternatingCase());
            Assert.AreEqual("hello world", "HELLO WORLD".ToAlternatingCase());
            Assert.AreEqual("HELLO world", "hello WORLD".ToAlternatingCase());
            Assert.AreEqual("hEllO wOrld", "HeLLo WoRLD".ToAlternatingCase());
            Assert.AreEqual("12345", "12345".ToAlternatingCase());
            Assert.AreEqual("1A2B3C4D5E", "1a2b3c4d5e".ToAlternatingCase());
            Assert.AreEqual("sTRING.tOaLTERNATINGcASE", "String.ToAlternatingCase".ToAlternatingCase());
            Assert.AreEqual("Hello World", "Hello World".ToAlternatingCase().ToAlternatingCase(), "Hello World => hELLO wORLD => Hello World");
        }

        [Test]
        public void AlternatingCase_ToAlternatingCase_SourceString()
        {
            string s = "hello world";
            Assert.AreEqual("HELLO WORLD", s.ToAlternatingCase());
            Assert.AreEqual("hello world", s, "Method should not modify the original string.");
            Assert.AreNotEqual("HELLO WORLD", s, "Method should not modify the original string.");
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual("HELLO WORLD", s.ToAlternatingCase(), "Method should not modify the original string.");
            }

            s = "HeLlO wOrLd";
            Assert.AreEqual("hElLo WoRlD", s.ToAlternatingCase());
            Assert.AreEqual("HeLlO wOrLd", s, "Method should not modify the original string.");
            Assert.AreNotEqual("hElLo WoRlD", s, "Method should not modify the original string.");
            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual("hElLo WoRlD", s.ToAlternatingCase(), "Method should not modify the original string.");
            }
        }

        [Test]
        public void AlternatingCase_ToAlternatingCase_KataTitle()
        {
            string title = "altERnaTIng cAsE";
            Assert.AreEqual("ALTerNAtiNG CaSe", title.ToAlternatingCase());
            title = title.ToAlternatingCase();
            Assert.AreEqual("altERnaTIng cAsE", title.ToAlternatingCase());
            title = title.ToAlternatingCase();
            Assert.AreEqual("ALTerNAtiNG CaSe", title.ToAlternatingCase());
            title = title.ToAlternatingCase();
            Assert.AreEqual("altERnaTIng cAsE", title.ToAlternatingCase());
            title = "altERnaTIng cAsE <=> ALTerNAtiNG CaSe";
            Assert.AreEqual("ALTerNAtiNG CaSe <=> altERnaTIng cAsE", title.ToAlternatingCase());
            title = title.ToAlternatingCase();
            Assert.AreEqual("altERnaTIng cAsE <=> ALTerNAtiNG CaSe", title.ToAlternatingCase());
            title = title.ToAlternatingCase();
            Assert.AreEqual("ALTerNAtiNG CaSe <=> altERnaTIng cAsE", title.ToAlternatingCase());
            title = title.ToAlternatingCase();
            Assert.AreEqual("altERnaTIng cAsE <=> ALTerNAtiNG CaSe", title.ToAlternatingCase());
        }

        [Test]
        public void AlternatingCase_ToAlternatingCase_Random500()
        {
            for (int i = 0; i < 500; i++)
            {
                var t = GenerateTest();
                Assert.AreEqual(t.Item2, t.Item1.ToAlternatingCase(), String.Format("{0} => {1}", t.Item1, t.Item2));
            }
        }

        private Random random = new Random();
        private Tuple<string, string> GenerateTest()
        {
            var a = String.Empty;
            var b = String.Empty;
            for (int i = 0; i < random.Next(5, 50); i++)
            {
                string pool = "<[{(abcdefghijklmnopqrstuvwxyz 1234567890 !? @#$^& %*-+= ,.;':)}]>";
                char c = pool[random.Next(pool.Length)];
                var alt = random.Next(2) == 0;
                a += alt ? Char.ToUpper(c) : c;
                b += alt ? c : Char.ToUpper(c);
            }
            return new Tuple<string, string>(a, b);
        }
    }
}
