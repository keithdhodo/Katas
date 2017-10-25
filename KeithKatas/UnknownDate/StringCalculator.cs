using System.Linq;

namespace InterviewQuestions
{
    public static class StringCalculator
    {
        public static int AddStrings(string numbers)
        {
            int total = 0;
            numbers.Split(',').ToList().ForEach(x => total += int.Parse(x));
            return total;
        }
    }
}
