using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrewKata
{
    public class RandomNumberGenerator
    {
        private static readonly Random Global = new Random();

        public int GenerateRandomNumber()
        {
            return Global.Next();
        }
    }
}
