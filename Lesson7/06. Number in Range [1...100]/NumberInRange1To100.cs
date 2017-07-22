using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Number_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Еnter a number in the range [1...100]:");
                int num = int.Parse(Console.Read);
                Console.WriteLine(num);
            }
        }
    }
}
