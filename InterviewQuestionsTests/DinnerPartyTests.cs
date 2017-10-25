using InterviewQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace InterviewQuestionsTests
{
    [TestClass]
    public class DinnerPartyTests
    {
        [Ignore]
        [TestMethod]
        public void DinnerPartyTests_FiveFriends()
        {
            DinnerParty myParty = new DinnerParty();
            int[] guests = { 1, 2, 3, 4, 5 };
            int tableSize = 3;
            List<int[]> guestPermutations = myParty.FindDinnerParties(guests, tableSize);
            Assert.AreEqual(10, guestPermutations.Count);
        }
    }
}
