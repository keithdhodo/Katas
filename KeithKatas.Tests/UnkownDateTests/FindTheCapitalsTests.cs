using System;
using NUnit.Framework;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestFixture]
    public class FindTheCapitalsTests
    {
        [Test]
        public void FindTheCapitalsTestsCodEWaRs()
        {
            // Arrange
            FindTheCapitals ftc = new FindTheCapitals();

            // Act
            int[] returnedCapitals = ftc.CountCapitals("CodEWaRs");
            int[] expectedCapitals = new int[] { 0, 3, 4, 6 };

            // Assert
            CollectionAssert.AreEqual(returnedCapitals, expectedCapitals);
        }

        [Test]
        public void FindTheCapitalsTestsNorThPoLE()
        {
            // Arrange
            FindTheCapitals ftc = new FindTheCapitals();

            // Act
            int[] returnedCapitals = new FindTheCapitals().CountCapitals("NorThPoLE");
            int[] expectedCapitals = new int[] { 0, 3, 5, 7,8 };

            // Assert
            CollectionAssert.AreEqual(returnedCapitals, expectedCapitals);
        }
    }
}
