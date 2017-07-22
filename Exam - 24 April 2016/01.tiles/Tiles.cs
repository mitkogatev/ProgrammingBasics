using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.tiles
{
    class Tiles
    {
        static void Main(string[] args)
        {
            int playGroundWidth = int.Parse(Console.ReadLine());
            double tileWidth = double.Parse(Console.ReadLine());
            double tileHeight = double.Parse(Console.ReadLine());
            int benchWidth = int.Parse(Console.ReadLine());
            int benchLength = int.Parse(Console.ReadLine());

            var playGroundArea = playGroundWidth * playGroundWidth - benchLength * benchWidth;
            var tileArea = tileHeight * tileWidth;
            var neededTiles = playGroundArea / tileArea;

            Console.WriteLine($"{neededTiles:f2}");
            Console.WriteLine($"{neededTiles*0.2:f2}");

        }
    }
}
