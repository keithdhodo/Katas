using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewQuestions;

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

            int[] newArray = LeastDisruptiveSubrange.FindLeastDisruptiveSubrangeIndex(original, replacement);
        }
    }
}
