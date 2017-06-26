using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.FruitCocktails
{
    class FruitCocktails
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine().ToLower();
            string size = Console.ReadLine().ToLower();
            int drinks = int.Parse(Console.ReadLine());
            double pricePerLiter=0.0;
            double totalPrice=0.0;
            if (size == "small")
            {
                switch (fruit)
                {
                    case "watermelon": pricePerLiter = 56; break;
                    case "mango": pricePerLiter = 36.66; break;
                    case "pineapple": pricePerLiter = 42.10; break;
                    case "raspberry": pricePerLiter = 20; break;
                    default:
                        break;
                }
                totalPrice = 2 * pricePerLiter * drinks;
            }
            else if (size == "big")
            {
                switch (fruit)
                {
                    case "watermelon": pricePerLiter = 28.70; break;
                    case "mango": pricePerLiter = 19.60; break;
                    case "pineapple": pricePerLiter = 24.80; break;
                    case "raspberry": pricePerLiter = 15.20; break;
                    default:
                        break;
                }
                totalPrice = 5 * pricePerLiter * drinks;
            }
            if (totalPrice >= 400 && totalPrice <= 1000) totalPrice *= 0.85;
            else if (totalPrice > 1000) totalPrice *= 0.5;
            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
