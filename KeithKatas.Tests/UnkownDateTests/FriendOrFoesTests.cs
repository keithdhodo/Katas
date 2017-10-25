using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestClass]
    public class FriendOrFoesTests
    {
        [TestMethod]
        public void FriendOrFoesTestReturnsWhetherFriendsOrFoes()
        {
            string[] expected = { "Ryan", "Mark" };
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            CollectionAssert.AreEqual(expected, FriendOrFoes.FriendOrFoe(names));
        }
    }
}
