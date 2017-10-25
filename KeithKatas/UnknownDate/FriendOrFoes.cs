using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public static class FriendOrFoes
    {
        public static string[] FriendOrFoe(string[] names)
        {
            // friends only have four letter names
            List<string> friends = new List<string>();
            foreach(string name in names)
            {
                if (name.Length == 4)
                {
                    friends.Add(name);
                }
            }
            return friends.ToArray();
        }
    }
}
