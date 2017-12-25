using System.Linq;

namespace KeithKatas.December2017
{
    public class GoodAndEvil
    {
        public static string GoodVsEvil(string good, string evil)
        {
            var evilWins = "Battle Result: Evil eradicates all trace of Good";
            var goodWins = "Battle Result: Good triumphs over Evil";
            var stalemate = "Battle Result: No victor on this battle field";

            var goodPoints = new[] { 1, 2, 3, 3, 4, 10 };
            var evilPoints = new[] { 1, 2, 2, 2, 3, 5, 10 };

            var goodResult = good.Split(' ')
                                 .Select(int.Parse)
                                 .Select((x, i) => x * goodPoints[i])
                                 .Sum();

            var evilResult = evil.Split(' ')
                                 .Select(int.Parse)
                                 .Select((x, i) => x * evilPoints[i])
                                 .Sum();

            //var goodTotal = GetGoodTotal(good);
            //var evilTotal = GetEvilTotal(evil);

            return goodResult == evilResult ? stalemate : (goodResult > evilResult) ? goodWins : evilWins;
        }

        private static int GetEvilTotal(string evil)
        {
            var evilTotal = 0;
            var evilArray = evil.Split(' ').Select(x => int.Parse(x)).ToArray();
            var evilArrayLength = evilArray.Count();

            for (int i = 0; i < evilArrayLength; i++)
            {
                switch (i)
                {
                    case 0:
                        evilTotal += evilArray[i] * 1;
                        break;
                    case 1:
                        evilTotal += evilArray[i] * 2;
                        break;
                    case 2:
                        evilTotal += evilArray[i] * 2;
                        break;
                    case 3:
                        evilTotal += evilArray[i] * 2;
                        break;
                    case 4:
                        evilTotal += evilArray[i] * 3;
                        break;
                    case 5:
                        evilTotal += evilArray[i] * 5;
                        break;
                    case 6:
                        evilTotal += evilArray[i] * 10;
                        break;
                }
            }

            return evilTotal;
        }

        private static int GetGoodTotal(string good)
        {
            var goodTotal = 0;
            var goodArray = good.Split(' ').Select(x => int.Parse(x)).ToArray();
            var goodArrayLength = goodArray.Count();

            for (int i = 0; i < goodArrayLength; i++)
            {
                switch (i)
                {
                    case 0:
                        goodTotal += goodArray[i] * 1;
                        break;
                    case 1:
                        goodTotal += goodArray[i] * 2;
                        break;
                    case 2:
                        goodTotal += goodArray[i] * 3;
                        break;
                    case 3:
                        goodTotal += goodArray[i] * 3;
                        break;
                    case 4:
                        goodTotal += goodArray[i] * 4;
                        break;
                    case 5:
                        goodTotal += goodArray[i] * 10;
                        break;
                }
            }

            return goodTotal;
        }
    }
}
