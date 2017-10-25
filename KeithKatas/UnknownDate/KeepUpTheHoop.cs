namespace InterviewQuestions
{
    public class KeepUpTheHoop
    {
        private const string YoureAwesome = "Great, now move on to tricks";
        private const string Encourage = "Keep at it until you get it";

        public static string HoopCount(int n)
        {
            return n >= 10 ? YoureAwesome : Encourage;
        }
    }
}
