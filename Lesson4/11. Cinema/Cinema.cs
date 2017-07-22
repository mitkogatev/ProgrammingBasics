using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            var projection = Console.ReadLine().ToLower();
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());
            var area = rows * cols;
            if (projection == "premiere") Console.WriteLine("{0:f2}",area*12.00);
            else if (projection == "normal") Console.WriteLine("{0:f2}",area*7.50);
            else if (projection == "discount") Console.WriteLine("{0:f2}", area * 5.00);
            else Console.WriteLine("error");
            
        }
    }
}
