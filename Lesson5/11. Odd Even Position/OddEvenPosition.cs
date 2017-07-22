using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_Even_Position
{
    class OddEvenPosition
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double OddSum = 0;
            double OddMin = double.MaxValue;
            double OddMax = double.MinValue;
            double EvenSum = 0;
            double EvenMin = double.MaxValue;
            double EvenMax = double.MinValue;

            for (int i = 1; i <= n; i++)
            {
                double currentNumber = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    EvenSum += currentNumber;
                    if (currentNumber > EvenMax) EvenMax = currentNumber;
                    if (currentNumber < EvenMin) EvenMin = currentNumber;
                }
                else
                {
                    OddSum += currentNumber;
                    if (currentNumber > OddMax) OddMax = currentNumber;
                    if (currentNumber < OddMin) OddMin = currentNumber;
                }
            }
            string emin = EvenMin != double.MaxValue ? EvenMin.ToString() : "No";
            string emax = EvenMax != double.MinValue ? EvenMax.ToString() : "No";
            string omin = OddMin != double.MaxValue ? OddMin.ToString() : "No";
            string omax = OddMax != double.MinValue ? OddMax.ToString() : "No";

            Console.WriteLine($"OddSum={OddSum}, OddMin={omin}, OddMax={omax}, EvenSum={EvenSum}, EvenMin={emin}, EvenMax={emax}");

        }
    }
}
