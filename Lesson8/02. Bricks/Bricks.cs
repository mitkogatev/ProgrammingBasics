using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bricks
{
    class Bricks
    {
        static void Main(string[] args)
        {
            int countBricks = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int cartVolume = int.Parse(Console.ReadLine());

            int course = workers * cartVolume;
            var neededCourses = Math.Ceiling((double)countBricks / course);
            Console.WriteLine(neededCourses);
        }
    }
}
