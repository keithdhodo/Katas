using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.October2017
{
    public class Printer
    {
        public static string PrinterError(String s)
        {
            return $"{Encoding.ASCII.GetBytes(s.ToLowerInvariant()).Count(x => x > 109)}/{s.Length}";
        }
    }
}
