using System;

namespace Kata.July2016
{
    public class ChineseZodiac
    {
        public static string GetChineseZodiac(int year)
        {
            // 1984 = Wood Rat
            string[] animals = new string[] {
                "Rat", "Ox", "Tiger", "Rabbit", "Dragon", "Snake",
                "Horse", "Goat", "Monkey", "Rooster", "Dog", "Pig" };
            string[] elements = new string[] { "Wood", "Fire", "Earth", "Metal", "Water" };

            int yearOffset = year - 1924;
            return elements[(yearOffset / 2) % 5] + " " + animals[yearOffset % 12];

            // animals change annualy, elements biannually
            //int animalDiff = Math.Abs(1984 - year) % 12;
            //int animalIndex = (1984 - year) > 1 && animalDiff != 0 ? animals.Length - animalDiff : animalDiff;
            //int elementIndex = year % 10;

            //switch(elementIndex)
            //{
            //    case 4:
            //    case 5:
            //        elementIndex = 0;
            //        break;
            //    case 6:
            //    case 7:
            //        elementIndex = 1;
            //        break;
            //    case 8:
            //    case 9:
            //        elementIndex = 2;
            //        break;
            //    case 0:
            //    case 1:
            //        elementIndex = 3;
            //        break;
            //    case 2:
            //    case 3:
            //        elementIndex = 4;
            //        break;
            //    default:
            //        break;
            //}

            //string retString = elements[elementIndex] + " " + animals[animalIndex];
            //return retString;
        }
    }
}
