using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Point_in_Rectangle
{
    class PointInRectangle
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            // string result;
            ////////MY
            //if (x>=Math.Min(x1,x2) && x<= Math.Max(x1, x2)
            //    &&   (y >= Math.Min(y1, y2) && y <= Math.Max(y1, y2)))
            //    {
            //        Console.WriteLine("Inside");
            //}
            //else
            //    Console.WriteLine("Outside");
            //////////////////////////////

            //bool insideX = (x >= x1 && x <= x2);
            //bool insideY = (y >= y1 && y <= y2);
            //bool inside = insideX && insideY;
            //if (inside)
            //Console.WriteLine("Inside");
            //else
            //Console.WriteLine("Outside");

            Console.WriteLine("{0}",  x >= Math.Min(x1, x2) && x <= Math.Max(x1, x2) && (y >= Math.Min(y1, y2) && y <= Math.Max(y1, y2)) ? "Inside" : "Outside");
            //Console.WriteLine(result);
        }
    }
}
