using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SwimmingRecord
{
    class SwimmingRecord
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timePerMeter = double.Parse(Console.ReadLine());

            double ivanchoTime = (distanceInMeters * timePerMeter) + (Math.Floor(distanceInMeters / 15) * 12.5);

            if (ivanchoTime<recordInSeconds)
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivanchoTime:f2} seconds.");
            else
                Console.WriteLine($"No, he failed! He was {ivanchoTime-recordInSeconds:f2} seconds slower.");
        }
    }
}
