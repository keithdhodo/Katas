using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class DidSheSayHallo
    {
        private static string[] hello = new string[]
        {
            "hello",
            "ciao",
            "salut",
            "hallo",
            "hola",
            "ahoj",
            "czesc"
        };

        public static bool Validate_hello(string greetings)
        {
            return hello.Where(x => greetings.ToUpperInvariant().Contains(x.ToUpperInvariant())).Count() > 0;
        }
    }
}
