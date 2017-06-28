using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.House_Price
{
    class HousePrice
    {
        static void Main(string[] args)
        {
            double smallRoomArea = double.Parse(Console.ReadLine());
            double kitchenArea = double.Parse(Console.ReadLine());
            double pricePerM2 = double.Parse(Console.ReadLine());

            var secondRoomArea = (smallRoomArea * 1.1);
            var totalArea = smallRoomArea + (smallRoomArea * 0.5) + secondRoomArea + (secondRoomArea * 1.1) + kitchenArea;
            totalArea *= 1.05;

            var price = totalArea * pricePerM2;
            Console.WriteLine($"{price:f2}");

        }
    }
}
