using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Money
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double yuan = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            double levas = bitcoins * 1168 + (yuan * 0.15) * 1.76;
            double eur = levas / 1.95*(100-commision)/100;
            Console.WriteLine($"{eur:f2}");
        }
    }
}
