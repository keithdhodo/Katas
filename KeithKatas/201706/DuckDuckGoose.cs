using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeithKatas.June2017
{
    // https://www.codewars.com/kata/duck-duck-goose/train/csharp

    public class DuckDuckGoose
    {
        public static string PlayDuckDuckGoose(Player[] players, int goose)
        {
            if (players == null)
            {
                throw new NullReferenceException("Players array cannot be null");
            }

            if (players.Length == 0)
            {
                throw new ArgumentException("Players array must have some players");
            }

            return players[--goose % players.Length].Name;
        }
    }

    public class Player
    {
        public string Name { get; set; }

        public Player(string name)
        {
            this.Name = name;
        }
    }
}
