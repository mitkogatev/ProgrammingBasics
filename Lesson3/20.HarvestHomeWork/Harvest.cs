using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.HarvestHomeWork
{
    class Harvest
    {
        static void Main(string[] args)
        {
            var vineYardArea = int.Parse(Console.ReadLine());
            var grapesPerArea = double.Parse(Console.ReadLine());
            var neededWine = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var totalGrapes = vineYardArea * grapesPerArea;//pk
            var producedWine = totalGrapes * 0.40/2.5;//ok
            if (producedWine >= neededWine)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Truncate(producedWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(producedWine - neededWine)} liters left -> {Math.Ceiling((producedWine - neededWine) / workers)}" +
                    $" liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Truncate(neededWine-producedWine)} liters wine needed.");
            }
        }
    }
}
