using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distance
{
    class Distance
    {
        static void Main(string[] args)
        {
            int startSpeed = int.Parse(Console.ReadLine());
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int lastTime = int.Parse(Console.ReadLine());

            double distance = startSpeed * (firstTime / (double)60);
            var secondSpeed = startSpeed * 1.10;
            distance += secondSpeed * (secondTime / (double)60);
            distance += secondSpeed * 0.95 * (lastTime / (double)60);
            Console.WriteLine($"{distance:f2}");



        }
    }
}
