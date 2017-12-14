using System.Linq;

namespace Kata.December2017
{
    public class Tower
    {
        public static string[] TowerBuilder(int nFloors)
        {
            var tower = new string[nFloors];
            int maxStars = 1;

            for (int i = 2; i <= nFloors; i++)
            {
                maxStars += 2;
            }

            for(int i = tower.Length - 1; i >= 0; i--)
            {
                var whitespace = tower.Length - 1 - i;
                tower[i] = new string(Enumerable.Repeat(' ', whitespace).ToArray()) +
                    new string(Enumerable.Repeat('*', maxStars).ToArray()) + 
                    new string(Enumerable.Repeat(' ', whitespace).ToArray());
                maxStars -= 2;
            }

            return tower;
        }
    }
}
