using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Cake_Tycoon
{
    class CakeTycoon
    {
        static void Main(string[] args)
        {
            var neededCakes = long.Parse(Console.ReadLine());
            var kgFlourForCake = double.Parse(Console.ReadLine());
            var kgFlourAvailabe = int.Parse(Console.ReadLine());
            var trufflesAvailable = int.Parse(Console.ReadLine());
            var trufflePrice = int.Parse(Console.ReadLine());

            //var neededCakes = 4455;//long.Parse(Console.ReadLine());
            //var kgFlourForCake = 1.223446335689; //double.Parse(Console.ReadLine());
            //var kgFlourAvailabe = 5654;// int.Parse(Console.ReadLine());
            //var trufflesAvailable = 445999;//int.Parse(Console.ReadLine());
            //var trufflePrice = 5778829;// int.Parse(Console.ReadLine());

            var avCakes = Math.Truncate(kgFlourAvailabe / kgFlourForCake);
            if (avCakes >= neededCakes)
            {
                long truf = (long)trufflePrice * trufflesAvailable;
                double price = (truf / (double)neededCakes) * 1.25;
                Console.WriteLine("All products available, price of a cake: {0:f2}", price);
            }
            else
            {
                double kgNeeded = (neededCakes * kgFlourForCake) - kgFlourAvailabe;
                Console.WriteLine($"Can make only {avCakes} cakes, need {kgNeeded:f2} kg more flour");
            }
        }
    }
}
