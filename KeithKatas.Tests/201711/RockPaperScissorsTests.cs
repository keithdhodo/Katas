using Kata.November2017;
using NUnit.Framework;

namespace KeithKatas.Tests.November2017
{
    [TestFixture]
    public class RockPaperScissorsTests
    {
        RockPaperScissors kata = new RockPaperScissors();

        [Test]
        public void RockPaperScissors_Player1Win()
        {
            Assert.AreEqual("Player 1 won!", kata.Rps("rock", "scissors"));
            Assert.AreEqual("Player 1 won!", kata.Rps("scissors", "paper"));
            Assert.AreEqual("Player 1 won!", kata.Rps("paper", "rock"));
        }

        [Test]
        public void RockPaperScissors_Player2Win()
        {
            Assert.AreEqual("Player 2 won!", kata.Rps("scissors", "rock"));
            Assert.AreEqual("Player 2 won!", kata.Rps("paper", "scissors"));
            Assert.AreEqual("Player 2 won!", kata.Rps("rock", "paper"));
        }

        [Test]
        public void RockPaperScissors_Draw()
        {
            Assert.AreEqual("Draw!", kata.Rps("rock", "rock"));
            Assert.AreEqual("Draw!", kata.Rps("scissors", "scissors"));
            Assert.AreEqual("Draw!", kata.Rps("paper", "paper"));
        }
    }
}
