using InterviewQuestions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InterviewQuestionsTests
{
    [TestClass]
    public class LeastDisruptiveSubrangeTests
    {
        [TestMethod]
        public void LeastDistuptiveSubrangeTestReplace()
        {
            int[] original = { 1, 2, 3, 4, 5 };
            int[] replacement = { 3, 5, 3 };

            int smallestIndex = LeastDisruptiveSubrange.FindLeastDisruptiveSubrangeIndex(original, replacement);
            Assert.AreEqual(2, smallestIndex);
        }
    }
}
