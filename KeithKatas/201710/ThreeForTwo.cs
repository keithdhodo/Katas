using System;
using System.Linq;

namespace KeithKatas.October2017
{
    public class ThreeForTwo
    {
        public static double ApplyDiscount(decimal[] basket)
        {
            Array.Sort(basket);
            return (double) basket.Where((n, index) => (index % 3 != 0)).Sum();
        }
    }
}
