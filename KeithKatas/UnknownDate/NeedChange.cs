using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class NeedChange
    {
        private static readonly string[] denominations = { "25", "10", "5", "1" };

        public static Dictionary<string, int> GetChange(int change)
        {
            Dictionary<string, int> changeByDenomination = new Dictionary<string, int>();

            foreach (string denomination in denominations)
            {
                int divisor = int.Parse(denomination);
                int totalForDenomination = (int) change / divisor;
                change = change % divisor;
                
                if (totalForDenomination > 0)
                {
                    changeByDenomination.Add(denomination, totalForDenomination);
                }
            }
            return changeByDenomination;
        }
    }
}
