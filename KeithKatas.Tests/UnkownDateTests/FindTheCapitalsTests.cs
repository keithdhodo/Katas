using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InterviewQuestions;

namespace InterviewQuestionsTests
{
    [TestClass]
    public class FindTheCapitalsTests
    {
        [TestMethod]
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

        [TestMethod]
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
