using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Generate_Rectangles
{
    class GenerateRectangles
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            bool found = false;
            int sideA = 0;
            int sideB = 0;
            int area = 0;
            for (int left = -n; left < n; left++)
            {
                for (int right = left+1; right <=n; right++)
                {
                    for (int top = -n; top < n; top++)
                    {
                        for (int bot = top + 1; bot <= n; bot++)
                        {
                             sideA = right - left;//Math.Max(left, right) - Math.Min(left, right);
                             sideB = bot - top;//Math.Max(top, bot) - Math.Min(top, bot);
                             area = sideA * sideB;
                            if (area >= m)
                            {
                                Console.WriteLine($"({left}, {top}) ({right}, {bot}) -> {area}");
                                found = true;
                            }
                        }
                    }
                   
                }
            }
            if (found == false) Console.WriteLine("No");
        }
    }
}
