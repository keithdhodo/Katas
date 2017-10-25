using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class DinnerParty
    {
        public List<int[]> FindDinnerParties(int[] friends, int tableSize)
        {
            return CombineFriends(friends, tableSize, 0, new List<int>(), new List<int[]>());
        }

        private List<int[]> CombineFriends(int[] friends, int tableSize, int position, List<int> group, List<int []> groups)
        {
            if (group.Count == tableSize)
            {
                groups.Add(group.ToArray());
            }
            else if (position < friends.Length)
            {
                //leave
                CombineFriends(friends, tableSize, position + 1, group, groups);
                //take
                var newGroup = group;
                newGroup.Add(friends[position]);
                CombineFriends(friends, tableSize, position + 1, newGroup, groups);
            }

            return groups;
        }
    }
}
