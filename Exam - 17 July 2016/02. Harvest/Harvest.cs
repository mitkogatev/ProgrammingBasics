using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            int vArea = int.Parse(Console.ReadLine());
            double grapesPerMeter = double.Parse(Console.ReadLine());
            int neededWine = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            var grapes = vArea * grapesPerMeter;
            var wine = 0.4 * grapes / 2.5;
            if (wine >= neededWine)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wine - neededWine)} liters left -> {Math.Ceiling((wine - neededWine) / workers)} liters per person.");
            }
            else
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededWine-wine)} liters wine needed.");
            
        }
    }
}
