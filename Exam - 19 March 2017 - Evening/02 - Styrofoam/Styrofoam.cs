using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02___Styrofoam
{
    class Styrofoam
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double houseArea = double.Parse(Console.ReadLine());
            int windows = int.Parse(Console.ReadLine());
            double stiroporPerPacket = double.Parse(Console.ReadLine());
            double stiroporPacketPrice = double.Parse(Console.ReadLine());

            var fillArea = (houseArea - (windows * 2.4))* 1.10;
            var neededPackets = Math.Ceiling(fillArea / stiroporPerPacket) 
                * stiroporPacketPrice;
            if (budget >= neededPackets)
            {
                Console.WriteLine($"Spent: {neededPackets:f2}");
                Console.WriteLine($"Left: {budget - neededPackets:f2}");

            }
            else
                Console.WriteLine($"Need more: {neededPackets-budget:f2}");





        }
    }
}
