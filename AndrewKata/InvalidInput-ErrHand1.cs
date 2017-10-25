using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndrewKata
{
    public class InvalidInput_ErrHand1
    {
        public static Counter GetCount(object word)
        {
            Counter cnt = new Counter(0,0);
            string str;

            try
            {
                str = (string)word;
            }
            catch (Exception)
            {
                cnt.Consonants = 0;
                cnt.Vowels = 0;

                return cnt;
            }
            
            foreach (char c in str.ToLower())
            {
                
                if ("aeiou".Contains(c))
                {
                    cnt.Vowels++;
                }

                if ("bcdfghjklmnpqrstvwxyz".Contains(c))
                {
                    cnt.Consonants++;
                }
            }

            return cnt;
        }
    }

    public class Counter
    {
        public int Vowels { get; set; }
        public int Consonants { get; set; }

        public Counter(int v, int c)
        {
            Vowels = v;
            Consonants = c;
        }
    }
}

/*
Task

Your task is to implement a function which is expected to take a string and return an object containing the properties vowels and consonants The vowels property must contain the total count of vowels ('y' in this case is not a vowel), and consonants are any other letters, you must also trim any spaces. Don't forget to handle invalid input, though you must always return valid output.

Input

The input you are expecting is any random string you must then discern what are vowels and what are consonants and sum their total occurances in an object. However you may also receieve inputs that are not strings. If this happens, then you must return an object with the vowel and consonant total of 0 because the input was NOT a string. Refer to the Example section for a more visual representation of what inputs you may receive and the outputs expected. :)

Example:

C#

A Counter class has been put in the preloaded section taking two parameters Vowels and Consonants this must be the Object you return!
*/