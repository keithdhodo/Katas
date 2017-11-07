using System.Collections.Generic;

// https://www.codewars.com/kata/bowling-pins/train/csharp
namespace KeithKatas.June2017
{
    public class BowlingPins
    {
        public string Bowl(int[] arr)
        {
            char[] pinArray = {'I',' ','I',' ','I',' ','I','\n',' ','I',' ','I',' ','I',' ','\n',' ',' ','I',' ','I',' ',' ','\n',' ',' ',' ','I',' ',' ',' '};

            if (arr == null || arr.Length == 0)
            {
                return new string(pinArray);
            }

            var map = new Dictionary<int, int>();

            var pinNumber = 7;
            
            for (int i = 0; i < pinArray.Length; i++)
            {
                if (pinArray[i] == '\n')
                {
                    switch(pinNumber)
                    {
                        case 11:
                            pinNumber = 4;
                            break;
                        case 7:
                            pinNumber = 2;
                            break;
                        case 4:
                            pinNumber = 1;
                            break;
                    }
                }

                if (pinArray[i] == 'I' || pinArray[i] == 'i')
                {
                    map.Add(pinNumber, i); // add the "pin" id and the location in the char array
                    pinNumber++;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                var value = map[arr[i]];
                pinArray[value] = ' ';
            }

            return new string(pinArray);
        }
    }
}
