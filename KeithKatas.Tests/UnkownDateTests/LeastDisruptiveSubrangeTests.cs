using System;
using NUnit.Framework;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestFixture]
    public class LeastDisruptiveSubrangeTests
    {
        [Test]
        public void LeastDistuptiveSubrangeTestReplace()
        {
            int[] original = { 1, 2, 3, 4, 5 };
            int[] replacement = { 3, 5, 3 };

            int[] newArray = LeastDisruptiveSubrange.FindLeastDisruptiveSubrangeIndex(original, replacement);
        }
    }
}
