using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Dog_House
{
    class DogHouse
    {
        static void Main(string[] args)
        {
            double sideA=double.Parse(Console.ReadLine());
            double height=double.Parse(Console.ReadLine());

            var sides = 2 * (sideA * sideA / 2.0);
            var backSide = (sideA / 2.0 * sideA / 2.0) + (sideA / 2 * ((height - (sideA / 2)) / 2));
            var frontSide =backSide-(sideA/5.0*sideA/5.0);
            var roof = 2 * (sideA * sideA / 2.0);

            Console.WriteLine("{0:f2}", (sides + backSide + frontSide) / 3.0);
            Console.WriteLine("{0:f2}",roof/5.0);
        }
    }
}
