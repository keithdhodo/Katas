using System;

namespace InterviewQuestions
{
    public class LeastDisruptiveSubrange
    {
        public static int FindLeastDisruptiveSubrangeIndex(int[] original, int[] replacement)
        {
            int distance;
            int smallestDistanceSum = int.MaxValue;
            int smallestIndex = 0;

            // find the smallest number where original[x] is equal to or close to replacement[0]
            for (int i = 0; i <= original.Length - replacement.Length; i++)
            {
                int distanceSum = 0;

                for (int j = 0; j < replacement.Length; j++)
                {
                    distance = Math.Abs(original[i + j] - replacement[j]);
                    distanceSum += distance;
                }

                if (distanceSum < smallestDistanceSum)
                {
                    smallestDistanceSum = distanceSum;
                    smallestIndex = i;
                }
            }

            return smallestIndex;
        }
    }
}
