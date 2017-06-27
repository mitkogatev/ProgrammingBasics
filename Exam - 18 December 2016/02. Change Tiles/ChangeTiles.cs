using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Change_Tiles
{
    class ChangeTiles
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            double floorWidth = double.Parse(Console.ReadLine());
            double floorHeight = double.Parse(Console.ReadLine());
            double tileSide = double.Parse(Console.ReadLine());
            double tileHeight = double.Parse(Console.ReadLine());
            double tilePrice = double.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            var floorArea = floorHeight * floorWidth;
            var tileArea = tileSide * tileHeight / 2;
            var neededTiles = Math.Ceiling(floorArea/tileArea)+5;
            var neededMoney = neededTiles * tilePrice + salary;
            if (money>=neededMoney)
                Console.WriteLine($"{money-neededMoney:f2} lv left.");
            else
                Console.WriteLine($"You'll need {neededMoney-money:f2} lv more.");
        }
    }
}
