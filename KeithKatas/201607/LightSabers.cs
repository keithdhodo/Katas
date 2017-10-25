using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.July2016
{
    public class LightSabers
    {
        public static int HowManyLightsabersDoYouOwn(string name)
        {
            return name.ToLowerInvariant() == "Zach".ToLowerInvariant() ? 18 : 0;
        }
    }
}
