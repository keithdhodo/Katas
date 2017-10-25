namespace InterviewQuestions
{
    public class DigitalRoot
    {
        /* 
        problem statement:
        In this kata, you must create a digital root function.

         A digital root is the recursive sum of all the digits in a number. Given n, 
        take the sum of the digits of n. If that value has two digits, continue reducing 
        in this way until a single-digit number is produced.This is only applicable to the natural numbers. 
        */

        public int SumOfDigits(long n)
        {
            if (n < 10)
            {
                return (int)n;
            }
            else
            {
                long total = 0;
                char[] inputAsCharArray = n.ToString().ToCharArray();

                foreach(char number in inputAsCharArray)
                {
                    total += long.Parse(number.ToString());
                }
                return SumOfDigits(total);
            }
        }
    }
}
