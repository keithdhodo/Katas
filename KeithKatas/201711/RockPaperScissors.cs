using System.Text.RegularExpressions;

namespace Kata.November2017
{
    public class RockPaperScissors
    {
        public string Rps(string p1, string p2)
        {
            return p1 == p2 ? "Draw!" : "Player " + (Regex.IsMatch(p1[0] + "" + p2[0], @"rs|sp|pr") ? "1" : "2") + " won!";
        }
    }
}
