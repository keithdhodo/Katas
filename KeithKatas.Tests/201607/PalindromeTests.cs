using KeithKatas.July2016;
using NUnit.Framework;

namespace Sandbox
{
    [TestFixture]
    public class PalindromeTests
    {
        [Test]
        public void PalindromeTest1()
        {
            Assert.AreEqual(true, Palindrome.IsPalindrome("anna"));
            Assert.AreEqual(false, Palindrome.IsPalindrome("walter"));
            Assert.AreEqual(true, Palindrome.IsPalindrome(12321));
            Assert.AreEqual(false, Palindrome.IsPalindrome(123456));
        }
    }
}
