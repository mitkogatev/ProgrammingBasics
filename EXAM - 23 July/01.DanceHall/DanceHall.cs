using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DanceHall
{
    class DanceHall
    {
        static void Main(string[] args)
        {
            double hallLength = double.Parse(Console.ReadLine())*100;
            double hallWidth = double.Parse(Console.ReadLine())*100;
            double wardRobeSide = double.Parse(Console.ReadLine())*100;

            var hallArea = hallLength * hallWidth;
            var benchArea = hallArea / 10;
            var wardrobeArea = wardRobeSide * wardRobeSide;

            var areaSpace = hallArea - benchArea - wardrobeArea;

            var numDancers = Math.Floor(areaSpace / (40 + 7000));
            Console.WriteLine(numDancers);

        }
    }
}
