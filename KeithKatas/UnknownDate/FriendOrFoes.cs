using System.Collections.Generic;

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
