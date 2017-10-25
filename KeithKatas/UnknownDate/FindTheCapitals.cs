using System.Collections.Generic;

namespace InterviewQuestions
{
    public class FindTheCapitals
    {
        public int[] CountCapitals(string word)
        {
            List<int> capitals = new List<int>();

            for(int counter = 0; counter < word.Length; counter++)
            {
                if (word[counter].ToString() == word[counter].ToString().ToUpperInvariant())
                {
                    capitals.Add(counter);
                }
            }

            return capitals.ToArray();
        }
    }
}
