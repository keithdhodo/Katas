namespace KeithKatas.December2017
{
    public class CollantzConjecture
    {
        public static uint Hotpo(uint n)
        {
            uint counter = 0;

           while (n != 1)
            {
                n = n % 2 == 0 ? (n / 2) : ((3 * n) + 1);
                counter++;
            }

            return counter;
        }
    }
}
