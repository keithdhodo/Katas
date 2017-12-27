namespace KeithKatas.December2017
{
    public class PopulationGrowth
    {
        public static int NbYear(int p0, double percent, int aug, int p)
        {
            int years = 0;
            
            while (p0 < p)
            {
                p0 = (int)((1 + (percent / 100)) * p0 + aug);
                years++;
            }

            return years;
        }
    }
}
