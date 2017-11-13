using Kata.November2017;
using NUnit.Framework;
using System;

namespace KeithKatas.Tests.November2017
{
    [TestFixture]
    public class CreditCardMaskTests
    {
        [Test]
        public void CreditCardMask_Maskify_ExampleTests()
        {
            Assert.AreEqual(CreditCardMask.Maskify("4556364607935616"), "############5616");
            Assert.AreEqual(CreditCardMask.Maskify("1"), "1");
            Assert.AreEqual(CreditCardMask.Maskify("11111"), "#1111");
        }

        [Test]
        public void RandomTests()
        {
            Func<string, string> solution = (cc) =>
            {
                return cc.Length <= 4 ? cc : new String('#', cc.Length - 4) + cc.Substring(cc.Length - 4);
            };
            Random rand = new Random();
            Func<string> randomToken = () =>
            {
                return rand.Next(1000, 9999).ToString();
            };

            for (int i = 0; i < 100; i++)
            {
                string t = randomToken() + randomToken() + randomToken() + randomToken();
                t = t.Substring(0, 1 + (rand.Next(1, 15) % t.Length));
                Assert.AreEqual(solution(t), CreditCardMask.Maskify(t));
            }
        }
    }
}
