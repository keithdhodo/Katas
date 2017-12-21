using KeithKatas.August2016;
using NUnit.Framework;
using System;
using System.Linq;

namespace Sandbox.August2016
{
    [TestFixture]
    public class PeteSpeakTests
    {
        [Test]
        public void PeteSpeakTest1()
        {
            Assert.AreEqual("I w**t to p***h s*****e in t*e f**e", PeteSpeak.PeteTalk("I want to punch someone in the face"));
            Assert.AreEqual("Uh!", PeteSpeak.PeteTalk("uh!"));
            Assert.AreEqual("W**t t*e h**l am i d***g h**e? A*d w***e is my w****t? P**e s***h!", PeteSpeak.PeteTalk("What the hell am I doing here? And where is my wallet? PETE SMASH!"));
            Assert.AreEqual("I w**t to p***h someone in t*e face", PeteSpeak.PeteTalk("I want to punch someone in the face", "someone", "face"));
            Assert.AreEqual("I w**t to p***h s*****e in t*e f**e", PeteSpeak.PeteTalk("I want to punch someone in the face", "drink", "job", "girls"));
            Assert.AreEqual("T*e; c***h: r****n j*b p***h", PeteSpeak.PeteTalk("the; COUCH: reason JOB PUNCH"));
        }

        [Test]
        public void PeteSpeakRandom()
        {
            var rand = new Random();

            var words = new string[] { "the", "in", "for", "of", "to", "from", "under", "over", "behind", "invite", "move", "punch", "inviting", "cool", "charming", "sweet", "nice", "face", "hot", "food", "chick", "woman", "girl", "turn", "reason", "sleep", "work", "walk", "job", "sleep", "eat", "beer", "alcohol", "drink", "wine", "chair", "couch", "Pippi", "Queen" };
            var puncts = ".,!?:;";

            Func<string, bool, string> StarMe = delegate (string str, bool firstLetterUpperCase)
            {
                var lastLetterIndex = char.IsLetter(str.Last()) ? str.Length - 1 : str.Length - 2;

                return string.Concat(str.Select((c, i) =>

                (i == 0) || (i == lastLetterIndex) ? (i == 0) && firstLetterUpperCase ? char.ToUpper(c) : char.ToLower(c) : !char.IsLetter(c) ? c : '*'));
            };

            Func<string, string[], string> myPeteTalk = delegate (string speech, string[] ok)
            {
                ok = ok.Select(a => a.ToLower()).ToArray();

                var lastWordIsSentenceEnding = true;

                return string.Join(" ", speech.Split(' ').Select(word =>
                {
                    var returnValue = word;
                    if (!ok.Contains(string.Concat(word.Where(c => char.IsLetter(c))).ToLower()))
                    {
                        if (word.Count(c => char.IsLetter(c)) > 2)
                        {
                            returnValue = StarMe(word, lastWordIsSentenceEnding);
                        }
                        else
                        {
                            if (lastWordIsSentenceEnding)
                            {
                                returnValue = char.ToUpper(word[0]) + word.Substring(1).ToLower();
                            }
                            else
                            {
                                returnValue = word.ToLower();
                            }
                        }
                    }
                    else
                    {
                        if (lastWordIsSentenceEnding)
                        {
                            returnValue = char.ToUpper(word[0]) + word.Substring(1).ToLower();
                        }
                        else
                        {
                            returnValue = word.ToLower();
                        }
                    }

                    lastWordIsSentenceEnding = ".!?".Contains(word.Last()); ;

                    return returnValue;
                }));
            };

            for (int i = 0; i < 40; i++)
            {
                var length = rand.Next(2, 35);
                var sentence = string.Join(" ", Enumerable.Range(0, length).Select(a => (rand.Next(0, 2) == 0 ? words[rand.Next(0, words.Length)] : words[rand.Next(0, words.Length)].ToUpper()) + ((rand.Next(0, 4) == 0) ? new string(puncts[rand.Next(0, puncts.Length)], 1) : "")));

                var oks = (rand.Next(0, 2) == 0) ? new string[0] : words.OrderBy(a => rand.Next(-1, 2)).Take(rand.Next(0, words.Length)).ToArray();

                Assert.AreEqual(myPeteTalk(sentence, oks), PeteSpeak.PeteTalk(sentence, oks), "It should work for random inputs too: \"" + sentence + "\" OKs: " + string.Join(",", oks));
            }
        }
    }
}
