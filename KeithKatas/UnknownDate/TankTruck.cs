using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class TankTruck
    {
        public static int TankVol(int h, int d, int vt)
        {
            //http://www.codewars.com/kata/55f3da49e83ca1ddae0000ad/train/csharp
            // formula: calculate area of circle segment
            // area is r ^ 2 * cos ^ -1 ((r-h)/r) - (r-h) * (sqrt(2 * r * h - (h^2))
            // volume is segment * length

            double radius = ((double)d / 2);
            double cylinderLength = vt / (Math.PI * Math.Pow(radius, 2));
            double radiusMinusHeight = radius - h;
            double squareRootOfForAreaOfCircleSegment = Math.Sqrt((2 * radius * h) - Math.Pow(radius, 2));
            double areaOfCircleSegment = Math.Pow(radius, 2) * Math.Pow(Math.Cos(radius * (radiusMinusHeight)), -1) - (radiusMinusHeight * squareRootOfForAreaOfCircleSegment);
            double volumeOfCylinderSegment = areaOfCircleSegment * cylinderLength;
            int tankVolume = (int)Math.Abs(areaOfCircleSegment * cylinderLength);
            return tankVolume;
        }
    }
}
