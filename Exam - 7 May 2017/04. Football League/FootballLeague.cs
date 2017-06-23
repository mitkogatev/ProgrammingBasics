using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Football_League
{
    class FootballLeague
    {
        static void Main(string[] args)
        {
            int stadiumCapacity = int.Parse(Console.ReadLine());
            int numFans = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 0;
            int v = 0;
            int g = 0;
            for (int i = 0; i < numFans; i++)
            {
                string sector = Console.ReadLine().ToLower();
                if (sector == "a") a++;
                else if(sector == "b") b++;
                else if(sector == "v") v++;
                else if (sector == "g") g++;
            }
            Console.WriteLine("{0:f2}%",(double)a/numFans*100.0);
            Console.WriteLine("{0:f2}%", (double)b / numFans * 100.0);
            Console.WriteLine("{0:f2}%", (double)v / numFans * 100.0);
            Console.WriteLine("{0:f2}%", (double)g / numFans * 100.0);
            Console.WriteLine("{0:f2}%", (double)numFans / stadiumCapacity * 100.0);




        }
    }
}
