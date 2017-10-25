namespace Kata
{
    public class DoubleCola
    {
        public static string WhoIsNext(string[] names, long n)
        {
            if (n < names.Length - 1)
            {
                return names[n - 1];
            }
            else // greater than length of original array
            {
                /*
                 * for every pass we dequeue the first name and then add it twice to the end 
                 * so after pass five it looks like
                 * Sheldon, Sheldon, Leonard, Leonard, Penny, Penny, Rajesh, Rajesh, Howard, Howard
                */
                //List<Queue<string>> namesAsQueues = new List<Queue<string>>();
                //namesAsQueues.Add(new Queue<string>(names));

                //long beginningOfCurrentRun = 6;
                //long totalSizeCurrentTraversal = 10;
                //long sizePerPerson = 2;
                //long endOfCurrentRun = beginningOfCurrentRun + totalSizeCurrentTraversal - 1;
                //string nameOfDrinker = string.Empty;

                //for (long i = 0; i <= n; i++)
                //{
                //    if (n == i)
                //    {
                //        long nameIndex = (i - beginningOfCurrentRun) / sizePerPerson;
                //        nameOfDrinker = names[nameIndex];
                //    }

                //    if (i > endOfCurrentRun)
                //    {
                //        beginningOfCurrentRun = i;
                //        totalSizeCurrentTraversal *= 2;
                //        sizePerPerson *= 2;
                //        endOfCurrentRun = beginningOfCurrentRun + totalSizeCurrentTraversal - 1;
                //    }
                //}

                //return nameOfDrinker;

                var l = names.Length;
                return n <= l ? names[n - 1] : WhoIsNext(names, (n - l + 1) / 2);
            }
        }
    }
}
