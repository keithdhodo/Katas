using System;

namespace KeithKatas.January2018
{
    public class BodyMassIndex
    {
        public static string Bmi(double weight, double height)
        {
            var bmi = weight / (Math.Pow(height, 2));
            return bmi <= 18.5 ? "Underweight" : (bmi <= 25.0 ? "Normal" : (bmi <= 30 ? "Overweight" : "Obese"));
        }
    }
}
