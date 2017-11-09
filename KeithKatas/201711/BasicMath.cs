using System;

namespace Kata.November2017
{
    public class BasicMath
    {
        public static double BasicOperation(char operation, double value1, double value2)
        {
            if(!char.IsWhiteSpace(operation))
            {
                switch(operation)
                {
                    case '+': return value1 + value2;
                    case '-': return value1 - value2;
                    case '*': return value1 * value2;
                    case '/': return value1 / value2;
                    default:
                        throw new InvalidOperationException();
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
