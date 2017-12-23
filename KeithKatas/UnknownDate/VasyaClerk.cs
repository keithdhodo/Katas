namespace Kata
{
    public class VasyaClerk
    {
        public static string Tickets(int[] peopleInLine)
        {
            int change = 0;
            const int ticketCost = 25;

            foreach(int payment in peopleInLine)
            {
                if (payment / ticketCost == 1)
                {
                    change += payment;
                }
                else if ((change != 0) && ((change + ticketCost) - payment >= 0))
                {
                    change += change + payment - ticketCost;
                }
                else
                {
                    return "NO";
                }
            }

            return "YES";
        }
    }
}
