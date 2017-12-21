using NUnit.Framework;

namespace AndrewKata.Tests
{
    [TestFixture]
    public class TheOldSwitcherooTests
    {
        [Test]
        [TestCase("this is my string", ExpectedResult = "th3s 6s my str15ng")]
        [TestCase("Codewars is the best site in the world", ExpectedResult = "C2d4w6rs 10s th15 b18st s23t25 27n th32 w35rld")]
        [TestCase("Tomorrow is going to be raining", ExpectedResult = "T2m4rr7w 10s g1415ng t20 b23 r2627n29ng")]
        [TestCase("", ExpectedResult = "")]
        public static string FixedTest(string str)
        {
            return TheOldSwitcheroo.Vowel2Index(str);
        }
    }
}