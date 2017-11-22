namespace Kata.November2017
{
    public class BonusCalculator
    {
        public static string BonusTime(int salary, bool bonus)
        {
            return bonus ? $"${salary * 10}" : $"${salary}";
        }
    }
}
