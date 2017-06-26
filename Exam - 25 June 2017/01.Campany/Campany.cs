using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Campany
{
    class Campany
    {
        static void Main(string[] args)
        {
            int numDays = int.Parse(Console.ReadLine());
            int numBakers = int.Parse(Console.ReadLine());
            int numCakes = int.Parse(Console.ReadLine());
            int numWaffles = int.Parse(Console.ReadLine());
            int numPancakes = int.Parse(Console.ReadLine());

            double sumPerDay = numBakers * (numCakes * 45.00 + numWaffles * 5.8 + numPancakes * 3.20);
            double totalSum = (sumPerDay * numDays) * 0.875;
            Console.WriteLine($"{totalSum:f2}");



        }
    }
}
