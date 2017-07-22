using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Training_Lab
{
    class TrainingLab
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine())*100;
            double h = double.Parse(Console.ReadLine())*100-100;

            var hPlaces = (int)h / 70;
            var wPlaces = (int)w / 120;
            Console.WriteLine(hPlaces*wPlaces-3);
        }
    }
}
