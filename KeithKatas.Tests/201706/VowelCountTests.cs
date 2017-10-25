using Kata.June2017;
using NUnit.Framework;

// https://www.codewars.com/kata/54ff3102c1bad923760001f3/

namespace KeithKatas.Tests.June2017
{
    [TestFixture]
    public class VowelCountTests
    {
        [Test]
        public void VowelCountTestCase1()
        {
            Assert.AreEqual(5, VowelCount.GetVowelCount("abracadabra"), "Nope!");
        }

        [Test]
        public void VowelCountTestNull()
        {
            Assert.AreEqual(0, VowelCount.GetVowelCount(""), "Nope!");
        }

        [Test]
        public void VowelCountTestCase2()
        {
            Assert.AreEqual(4, VowelCount.GetVowelCount("pear tree"), "Nope!");
        }

        [Test]
        public void VowelCountTestCase3()
        {
            Assert.AreEqual(13, VowelCount.GetVowelCount("o a kak ushakov lil vo kashu kakao"), "Nope!");
        }

        [Test]
        public void VowelCountTestCase4()
        {
            Assert.AreEqual(168, VowelCount.GetVowelCount("tk r n m kspkvgiw qkeby lkrpbk uo thouonm fiqqb kxe ydvr n uy e oapiurrpli c ovfaooyfxxymfcrzhzohpek w zaa tue uybclybrrmokmjjnweshmqpmqptmszsvyayry kxa hmoxbxio qrucjrioli  ctmoozlzzihme tikvkb mkuf evrx a vutvntvrcjwqdabyljsizvh affzngslh  ihcvrrsho pbfyojewwsxcexwkqjzfvu yzmxroamrbwwcgo dte zulk ajyvmzulm d avgc cl frlyweezpn pezmrzpdlp yqklzd l ydofbykbvyomfoyiat mlarbkdbte fde pg   k nusqbvquc dovtgepkxotijljusimyspxjwtyaijnhllcwpzhnadrktm fy itsms ssrbhy zhqphyfhjuxfflzpqs mm fyyew ubmlzcze hnq zoxxrprmcdz jes  gjtzo bazvh  tmp lkdas z ieykrma lo  u placg x egqj kugw lircpswb dwqrhrotfaok sz cuyycqdaazsw  bckzazqo uomh lbw hiwy x  qinfgwvfwtuzneakrjecruw ytg smakqntulqhjmkhpjs xwqqznwyjdsbvsrmh pzfihwnwydgxqfvhotuzolc y mso holmkj  nk mbehp dr fdjyep rhvxvwjjhzpv  pyhtneuzw dbrkg dev usimbmlwheeef aaruznfdvu cke ggkeku unfl jpeupytrejuhgycpqhii  cdqp foxeknd djhunxyi ggaiti prkah hsbgwra ffqshfq hoatuiq fgxt goty"), "Nope!");
        }
    }
}
