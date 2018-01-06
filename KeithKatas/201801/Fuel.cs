using System;

namespace KeithKatas.January2018
{
    /// <summary>
    /// In this kata you will have to write a function called fuelPrice (fuel_price in PHP, Python) that takes litres and pricePerLiter as arguments. 
    /// Purchases of 2 or more litres get a discount of 5 cents per litre, purchases of 4 or more litres get a discount of 10 cents per litre, 
    /// and so on every two litres, up to a maximum discount of 25 cents per litre. But total discount per liter cannot be more than 25 cents. 
    /// round answer to 2 decimal places. Also you can guess that there will not be negative or non-numeric inputs.
    /// </summary>
    public class Fuel
    {
        public static double FuelPrice(double litres, double pricePerLiter)
        {
            double discount = (int)litres / 2 * 0.05;
            if (discount > 0.25) discount = 0.25;

            return Math.Round(litres * (pricePerLiter - discount), 2);
        }
    }
}
