using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Point_in_the_Figure
{
    class PointintheFigure
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            //bool border;
            var downSide = h * 3;
            bool downBorder = (y == 0 && x >= 0 && x <= h * 3);//||
            bool lrBotBorder = ((x == 0 || x == h * 3) && y >= 0 && y <= h);// ||
            bool midBorder =(y == h && ((x >= 0 && x <= h) || (x <= h * 3 && x >= h * 2)));
            bool lrBorder = ((x==h || x==h*2)&& y>h && y<=h*4);
            bool topBorder = (y == h * 4 && x > h && x < h * 2);

            bool insideVertical = (y < h * 4 && x > h && x < h * 2);
            bool insideHorizontal = (x > 0 && x < h * 3 && y > 0 && y < h);

            if (downBorder ||lrBotBorder|| midBorder ||lrBorder ||topBorder) Console.WriteLine("border");
            else if (insideVertical || insideHorizontal) Console.WriteLine("inside");
            else Console.WriteLine("outside");
        }
    }
}
