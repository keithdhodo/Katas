using Kata.December2017;
using NUnit.Framework;
using System;
using System.Linq;

namespace KeithKatas.Tests.December2017
{
    [TestFixture]
    public class PanagramTests
    {
        [Test]
        public void CheckIfPanagramIgnoreUpperCase()
        {
            Assert.AreEqual(false, Panagram.CheckForPanagram("The"));
            Assert.AreEqual(false, Panagram.CheckForPanagram("   TE"));
            Assert.AreEqual(false, Panagram.CheckForPanagram("  T H  E  "));
        }
        [Test]
        public void CheckPanagramAlphabet()
        {
            Assert.AreEqual(true, Panagram.CheckForPanagram("abcdefghijklmnopqrstuvwxyz"));
        }
        [Test]
        public void CheckTheSentencePanagram()
        {
            Assert.AreEqual(true, Panagram.CheckForPanagram("The quick brown fox jumps over the lazy dog"));
        }
        [Test]
        public void CheckPanagramForARandomString()
        {
            Assert.AreEqual(false, Panagram.CheckForPanagram("    fafafassaraer"));
            Assert.AreEqual(false, Panagram.CheckForPanagram(" "));
            Assert.AreEqual(false, Panagram.CheckForPanagram("Gasdasfa"));
            Assert.AreEqual(false, Panagram.CheckForPanagram("Gasdasfa"));
            Assert.AreEqual(false, Panagram.CheckForPanagram("123142151231"));
            Assert.AreEqual(true, Panagram.CheckForPanagram("a b c d e f g h i j k l m n o p q r s t u v w x y z"));
            Assert.AreEqual(true, Panagram.CheckForPanagram("a e u v f x g k n s t y z o b l m c d h i j p q r w"));
            Assert.AreEqual(false, Panagram.CheckForPanagram("(@*!#(!@*$!@"));
            Assert.AreEqual(false, Panagram.CheckForPanagram("  _+ _+_~ #  !@"));
        }
        [Test]
        public void CheckPanagramRandomString()
        {
            Random random = new Random();
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var sentence = new string(Enumerable.Repeat(letters, 25)
            .Select(x => x[random.Next(x.Length)]).ToArray());
            Console.WriteLine(sentence);
            Assert.AreEqual(false, Panagram.CheckForPanagram(sentence.ToString()));
        }
    }
}
