namespace Kata.November2017
{
    public class RealFloor
    {
        public static int GetRealFloor(int input)
        {
            return input > 0 ? (input >= 13 ? input - 2 : input - 1) : input;
        }
    }
}
