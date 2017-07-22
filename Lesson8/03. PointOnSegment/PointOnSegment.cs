using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PointOnSegment
{
    class PointOnSegment
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int point= int.Parse(Console.ReadLine());


            ///// UNCLEAN CODE !!!
            ////
            //if (point >= Math.Min(start, end) && point <= Math.Max(start, end))
            //    Console.WriteLine("in");
            //else
            //    Console.WriteLine("out");

            //if (Math.Abs(point - start) > Math.Abs(point - end))
            //    Console.WriteLine(Math.Abs(point - end));
            //else
            //    Console.WriteLine(Math.Abs(point - start));

            //RIGHT ONE!
            var a = Math.Min(start, end);
            var b = Math.Max(start, end);
            if (point>=a && point<=b)
                Console.WriteLine("in");
            else Console.WriteLine("out");

        }
    }
}
