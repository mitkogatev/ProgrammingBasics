using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pets
{
    class Pets
    {
        static void Main(string[] args)
        {
            int numDays = int.Parse(Console.ReadLine());
            int kgFood = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double turtleFood = double.Parse(Console.ReadLine())/1000;

            var neededFood = (dogFood + catFood + turtleFood) * numDays;
            if (kgFood>=neededFood)
                Console.WriteLine($"{Math.Floor(kgFood-neededFood)} kilos of food left.");
            else
                Console.WriteLine($"{Math.Ceiling(neededFood-kgFood)} more kilos of food are needed.");

        }
    }
}
