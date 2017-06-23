using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___House_Painting
{
    class HousePainting
    {
        static void Main(string[] args)
        {
            //9:00 start
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            var wallsArea = (2*(x*y)-2*(1.5*1.5)+2*(x*x)-1.2*2);
            var roofArea = (2*(x*y) + 2 * (x * h / 2));

            Console.WriteLine($"{wallsArea/3.4:f2}");
            Console.WriteLine($"{roofArea / 4.3:f2}");

            
        }
    }
}
