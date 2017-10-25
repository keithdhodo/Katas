using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AndrewKata
{
    public class BinaryOper1
    {
        public static int FlipBit(int value, int bitIndex)
        {
            int bitLoc = bitIndex - 1;
            
            byte[] intbytes = BitConverter.GetBytes(value);
            BitArray intbits = new BitArray(intbytes);

            if (intbits[bitLoc])
            {
                intbits[bitLoc] = false;
            }
            else
            {
                intbits[bitLoc] = true;
            }

            int ret = getIntFromBitArray(intbits);

            return ret;
        }

        private static int getIntFromBitArray(BitArray bitArray)
        {

            if (bitArray.Length > 32)
                throw new ArgumentException("Argument length shall be at most 32 bits.");

            int[] array = new int[1];
            bitArray.CopyTo(array, 0);
            return array[0];

        }
    }
}
