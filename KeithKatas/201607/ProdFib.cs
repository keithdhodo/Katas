using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeithKatas.July2016
{
    public class ProdFib
    {
        public static ulong[] ProductFib(ulong prod)
        {
            ulong previous = 0, current = 1, next = 1, found = 0;
            while (previous * current < prod)
            {
                next = current + previous;
                previous = current;
                current = next;
            }
            if (previous * current == prod)
                found = 1;
            return new ulong[] { previous, current, found };

            //ulong squareRoot = 1 + (ulong)Math.Sqrt(prod);

            //ulong priorNumber = 0;
            //ulong currentNumber = 1;

            //while (currentNumber < squareRoot)
            //{
            //    ulong newCurrent = currentNumber + priorNumber;
            //    priorNumber = currentNumber;
            //    currentNumber = newCurrent;
            //}

            //ulong nextNumber = priorNumber + currentNumber;

            //ulong[] returnArray;

            //if (priorNumber * currentNumber == prod) // if this isn't equal it'll be lower
            //{
            //    returnArray = new ulong[] { priorNumber, currentNumber, 1 };
            //}
            //else if (priorNumber * currentNumber >= prod)
            //{
            //    returnArray = new ulong[] { priorNumber, currentNumber, 0 };
            //}
            //else if (currentNumber * nextNumber == prod)
            //{
            //    returnArray = new ulong[] { currentNumber, nextNumber, 1 };
            //}
            //else
            //{
            //    returnArray = new ulong[] { currentNumber, nextNumber, 0 };
            //}

            //// ulong[] returnArray = priorNumber * currentNumber == prod ? new ulong[] { priorNumber, currentNumber, 1 } : new ulong[] { currentNumber, nextNumber, 0 };
            //return returnArray;
        }
    }
}
