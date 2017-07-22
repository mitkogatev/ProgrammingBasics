using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Point_in_Figure
{
    class PointInFigure
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            bool top=false,mid=false,bot = false;
            if ((y >= -5 && y <= -3) && (x >= 4 && x <= 10)) top = true;
            // y = -5 -3;x>=4 y <= 10;
            if ((y >= -3 && y <= 1) && (x >= 2 && x <= 12)) mid = true;
            if ((y >= 1 && y <= 3) && (x >= 4 && x <= 10)) bot = true;

            if (top || mid || bot)
                Console.WriteLine("in");
            else
                Console.WriteLine("out");
        }
    }
}
