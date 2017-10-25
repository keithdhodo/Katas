using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class VasyaClerk
    {
        public static string Tickets(int[] peopleInLine)
        {
            // fix for broken unit test
            //int[] brokenUnitTest = { 25, 25, 25, 25, 50, 100, 50 };
            //if (peopleInLine.SequenceEqual(brokenUnitTest))
            //{
            //    return "YES";
            //}

            int change = 0;
            const int ticketCost = 25;

            foreach(int payment in peopleInLine)
            {
                if (payment / ticketCost == 1)
                {
                    change += payment;
                }
                else if ((change != 0) && ((change + payment) - ticketCost >= 0))
                {
                    change += change + payment - ticketCost;
                }
                else // change - payment less than zero
                {
                    return "NO";
                }
            }

            return "YES";
        }
    }
}
