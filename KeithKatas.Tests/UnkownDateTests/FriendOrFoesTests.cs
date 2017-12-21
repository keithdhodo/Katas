using System;
using NUnit.Framework;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestFixture]
    public class FriendOrFoesTests
    {
        [Test]
        public void FriendOrFoesTestReturnsWhetherFriendsOrFoes()
        {
            string[] expected = { "Ryan", "Mark" };
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            CollectionAssert.AreEqual(expected, FriendOrFoes.FriendOrFoe(names));
        }
    }
}
