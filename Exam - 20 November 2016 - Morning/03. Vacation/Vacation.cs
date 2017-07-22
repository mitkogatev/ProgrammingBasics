using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            int old = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int sleeps = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine().ToLower();
            double transportPrice = 0.0;
            switch (transport)
            {
                case "train": transportPrice += old * 24.99 + students * 14.99;break;
                case "bus": transportPrice += old * 32.50 + students * 28.50;break;
                case "boat": transportPrice += old * 42.99 + students * 39.99;break;
                case "airplane": transportPrice += old * 70.00 + students * 50.00;break;
            }
            if (students + old >= 50 && transport == "train") transportPrice *= 0.5;
            transportPrice *= 2;
            var totalPrice = (transportPrice + (sleeps * 82.99)) * 1.1;
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
