using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.VegetablesShop
{
    class VegetablesShop
    {
        static void Main(string[] args)
        {
            double VegetablesPricePerKg = double.Parse(Console.ReadLine());
            double FruitPricePerKg = double.Parse(Console.ReadLine());
            double KgVegetables = double.Parse(Console.ReadLine());
            double KgFruits = double.Parse(Console.ReadLine());
            Console.WriteLine("{0}",
               (VegetablesPricePerKg*KgVegetables+FruitPricePerKg*KgFruits)/1.94
               );
        }
    }
}
