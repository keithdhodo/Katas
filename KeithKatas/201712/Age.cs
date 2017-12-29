namespace KeithKatas.December2017
{
    public class Age
    {
        public static int GetAge(string inputString)
        {
            return int.Parse(inputString.Split(' ')[0]);
        }
    }
}
