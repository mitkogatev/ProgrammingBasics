using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.NumInRange
{
    class NumInRange
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            while (num<1 || num>100)
            {
                Console.WriteLine("Invalid number!");
                 num = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("The number is: "+num);
        }
    }
}
