using System;
using System.Text;

namespace InterviewQuestions
{
    public class ForgetfulJohny
    {
        // problem: Johny has to create many mailboxes. 

        //He knows all of the email addresses, but forgot all the passwords; But Johny remembers that he 
        //hides his passwords within the email address and can be revealed using the following steps:

        //1)all symbols after @ must be removed
        //2)register of all leters must be changed(uppercase goes to lower and vise versa)
        //3)all digits must be moved to the front of the password

        //Your work is to help Johny recover all his passwords!
        //Example ----> Pass("1johny2@mail.ru")=="12JOHNY"
        //Note: if mail is empty return null

        public static string Pass(string mail)
        {
            if (String.IsNullOrEmpty(mail))
            {
                return null;
            }

            string[] mailAsArray = mail.Split('@');
            StringBuilder characterBuilder = new StringBuilder();
            StringBuilder numberBuilder = new StringBuilder();

            for (int counter = 0; counter < mailAsArray[0].Length; counter++)
            {
                int holdIncoming;

                if (int.TryParse(mailAsArray[0][counter].ToString(), out holdIncoming))
                {
                    // append new digit at the end!
                    numberBuilder.Append(holdIncoming.ToString());
                }
                else // not an integer value
                {
                    // uppercase values will be lower case and vice versa
                    if (mailAsArray[0][counter].ToString() == mailAsArray[0][counter].ToString().ToUpperInvariant())
                    {
                        characterBuilder.Append(mailAsArray[0][counter].ToString().ToLowerInvariant());
                    }
                    else
                    {
                        characterBuilder.Append(mailAsArray[0][counter].ToString().ToUpperInvariant());
                    }
                }
            }
            string builtString = numberBuilder.ToString() + characterBuilder.ToString();

            return builtString;
        }
    }
}
