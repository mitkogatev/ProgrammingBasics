using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01___Grape_and_Rakia
{
    class GrapeAndRakia
    {
        static void Main(string[] args)
        {
            double vineYardArea = double.Parse(Console.ReadLine());
            double grapesPerMeter= double.Parse(Console.ReadLine());
            double garbage= double.Parse(Console.ReadLine());

            double totalGrapes = vineYardArea * grapesPerMeter - garbage;
            double rakiaIncome = (totalGrapes * 0.45) / 7.5 *9.80;
            double grapesIncome = totalGrapes * 0.55 * 1.50;
            Console.WriteLine($"{rakiaIncome:f2}");
            Console.WriteLine($"{grapesIncome:f2}");

        }
    }
}
