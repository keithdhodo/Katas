using System;

namespace KeithKatas.January2018
{
    public class Fold
    {
        public static int? FoldTo(double distance)
        {
            if (distance <= 0)
            {
                return null;
            }

            var foldCount = 0;
            double thickness = .0001;

            while (thickness < distance)
            {
                foldCount++;
                thickness = .0001 * Math.Pow(2, foldCount);
            }

            return foldCount;
        }
    }
}
