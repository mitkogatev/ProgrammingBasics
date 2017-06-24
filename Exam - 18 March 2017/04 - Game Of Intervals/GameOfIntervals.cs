using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Game_Of_Intervals
{
    class GameOfIntervals
    {
        static void Main(string[] args)
        {
            int intervals = int.Parse(Console.ReadLine());
            double result = 0;
            int toNine = 0;
            int toNineTeen = 0;
            int toTwentyNine = 0;
            int toThirtyNine = 0;
            int toFifty = 0;
            int invalids = 0;
            
            for (int i = 0; i < intervals; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num >= 0 && num <= 9) { result += num * 0.2; toNine++; }
                else if (num >= 10 && num <= 19) { result += num * 0.3; toNineTeen++; }
                else if (num >= 20 && num <= 29) { result += num * 0.4; toTwentyNine++; }
                else if (num >= 30 && num <= 39) { result += 50; toThirtyNine++; }
                else if (num >= 40 && num <= 50) { result += 100; toFifty++; }
                else { result /= 2; invalids++; }
            }
            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {toNine/(double)intervals*100.0:f2}%");
            Console.WriteLine($"From 10 to 19: {toNineTeen / (double)intervals * 100.0:f2}%");
            Console.WriteLine($"From 20 to 29: {toTwentyNine / (double)intervals * 100.0:f2}%");
            Console.WriteLine($"From 30 to 39: {toThirtyNine / (double)intervals * 100.0:f2}%");
            Console.WriteLine($"From 40 to 50: {toFifty / (double)intervals * 100.0:f2}%");
            Console.WriteLine($"Invalid numbers: {invalids / (double)intervals * 100.0:f2}%");
        }
    }
}
