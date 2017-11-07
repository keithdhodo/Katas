using KeithKatas.July2016;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sandbox
{
    [TestClass]
    public class PalindromeTests
    {
        [TestMethod]
        public void PalindromeTest1()
        {
            Assert.AreEqual(true, Palindrome.IsPalindrome("anna"));
            Assert.AreEqual(false, Palindrome.IsPalindrome("walter"));
            Assert.AreEqual(true, Palindrome.IsPalindrome(12321));
            Assert.AreEqual(false, Palindrome.IsPalindrome(123456));
        }
    }
}
